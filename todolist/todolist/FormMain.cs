using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace todolist
{
    
    public partial class FormMain : Form
    {
        int project = 1;
        bool isMain;
        DateTime today = DateTime.Today;
        int id;
        public FormMain(int user_id)
        {
            InitializeComponent();
            id = user_id;
            getTasks();
            getProjects();
        }
        
        public void getTasks()
        {
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from tasks where task_id in(select task_id from user_task where user_id = '"+id+"') and status_id=1", mySql);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addtask(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy.MM.dd"), reader[3].ToString(),Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]));
                    }
                }
                mySql.Close();
            }

        }

        public void getProjects()
        {
            string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
            string sql = "SELECT * FROM projects";
            MySqlConnection conn = new MySqlConnection(connStr);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,conn);
            adapter.Fill(table);
            listBox_projects.DataSource = table;
            listBox_projects.DisplayMember = "project_name";
            listBox_projects.ValueMember = "project_id";
        }

        public void addtask(int id, string text, string date, string description, int priority,int project)
        {
            TaskControl item = new TaskControl( id,  text,  description,  date,  priority,  project);
            if (date==today.ToString("yyyy.MM.dd"))
            {
                panelToDay.Visible = true;
                panelToDay.Controls.Add(item);
                panelTodayLabel.Visible=true;
            }
            else if (Convert.ToDateTime(date)<today)
            {
                panelLeftTask.Visible = true;
                panelLeftTask.Controls.Add(item);
                panelLeftLabel.Visible = true;
            }
            else if (today < Convert.ToDateTime(date))
            {
                panelFutureTask.Visible = true;
                panelFutureTask.Controls.Add(item);
                panelLabelFuture.Visible = true;
            }
            item.Dock = DockStyle.Top;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormTaskAdd formTaskAdd = new FormTaskAdd(project,id);
            formTaskAdd.Show();
        }

        public void refresh()
        {
            panelToDay.Controls.Clear();
            panelFutureTask.Controls.Clear();
            panelLeftTask.Controls.Clear();
            panelToDay.Visible = false;
            panelTodayLabel.Visible = false;
            panelLeftTask.Visible = false;
            panelLeftLabel.Visible = false;
            panelFutureTask.Visible = false;
            panelLabelFuture.Visible = false;
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
            getProjects();
            listBox_projects.Update();
            if (isMain==false)
            {
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "SELECT * from tasks where project_id = '" + project + "';";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                try
                {
                    command.Connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        addtask(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy.MM.dd"), reader[3].ToString(), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]));
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка", ex.ToString());
                }
                finally
                {
                    command.Connection.Close();
                }
            }
            else getTasks();
        }

        private void button_addProject_Click(object sender, EventArgs e)
        {
            FormAddProject formAddProject = new FormAddProject();
            formAddProject.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            if (isMain==false)
            {
                isMain = true;
                buttonBackToMain.Visible = false;
                labelProject.Visible = false;
                buttonDeleteProject.Visible = false;
                buttonEditProject.Visible = false;
                panelToDay.Controls.Clear();
                panelFutureTask.Controls.Clear();
                panelLeftTask.Controls.Clear();
                getTasks();
            }
        }

        public void search()
        {
            
            panelToDay.Controls.Clear();
            panelFutureTask.Controls.Clear();
            panelLeftTask.Controls.Clear();
            panelToDay.Visible = false;
            panelTodayLabel.Visible = false;
            panelLeftTask.Visible = false;
            panelLeftLabel.Visible = false;
            panelFutureTask.Visible = false;
            panelLabelFuture.Visible = false;
            string searh_text= textBoxSearch.Text;
            if (isMain == false){
                MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
                using (mySql)
                {
                    mySql.Open();
                    MySqlCommand command = new MySqlCommand("select * from tasks where task_name like '%" + searh_text + "%' and project_id='"+project+ "' and task_id in(select task_id from user_task where user_id = '" + id + "')", mySql);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            addtask(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy.MM.dd"), reader[3].ToString(), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]));

                        }
                    }
                    mySql.Close();
                }
            }
            else
            {
                MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
                using (mySql)
                {
                    mySql.Open();
                    MySqlCommand command = new MySqlCommand("select * from tasks where task_name like '%" + searh_text + "%' and task_id in(select task_id from user_task where user_id = '" + id + "'", mySql);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            addtask(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy.MM.dd"), reader[3].ToString(), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]));

                        }
                    }
                    mySql.Close();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
            string sql = "Update tasks set date='"+today.ToString("yyyy.MM.dd")+"' where date<'" + today.ToString("yyyy.MM.dd") + "' and status_id=1";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            conn.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Перенесено на сегодня");
            conn.Close();
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("delete from projects where project_id='" + project + "'", mySql);
                command.ExecuteNonQuery();
                MessageBox.Show("Удалено");
            }
            mySql.Close();
            
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            FormEditProject formEditProject = new FormEditProject(project,labelProject.Text);
            formEditProject.Show();
        }

        private void listBox_projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_projects.SelectedValue is System.IFormattable)
            {
                refresh();
                buttonBackToMain.Visible = true;
                buttonDeleteProject.Visible = false;
                buttonEditProject.Visible = false;
                labelProject.Visible = true;
                isMain = false;
                project = Convert.ToInt32(listBox_projects.SelectedValue);
                labelProject.Text = listBox_projects.Text;
                if (project != 1)
                {
                    buttonDeleteProject.Visible = true;
                    buttonEditProject.Visible = true;
                }
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "SELECT * from tasks where project_id = '" + project + "'and task_id in(select task_id from user_task where user_id = '" + id + "');";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                try
                {
                    command.Connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        addtask(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy.MM.dd"), reader[3].ToString(), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]));
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка", ex.ToString());
                }
                finally
                {
                    command.Connection.Close();
                }
            }
        }
    }
}
