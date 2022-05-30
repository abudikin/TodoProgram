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
        DateTime today = DateTime.Today;
        int status;
        int id;
        public FormMain(int user_id)
        {
            InitializeComponent();
            getTasks();
            getProjects();
            id = user_id;
        }
        
        public void getTasks()
        {

            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from tasks", mySql);
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
        void getProjects()
        {

            string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
            string sql = "SELECT * FROM projects where project_id>1";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox_projects.Items.Add(reader["project_name"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }



        }

        public void addtask(int id, string text, string date, string description, int priority,int project)
        {
            //MessageBox.Show(today.ToShortDateString()+" "+date);
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
            FormTaskAdd formTaskAdd = new FormTaskAdd(project);
            formTaskAdd.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            panelToDay.Controls.Clear();
            panelFutureTask.Controls.Clear();
            panelLeftTask.Controls.Clear();
            listBox_projects.Items.Clear();
            panelToDay.Visible = false;
            panelTodayLabel.Visible = false;
            panelLeftTask.Visible = false;
            panelLeftLabel.Visible = false;
            panelFutureTask.Visible = false;
            panelLabelFuture.Visible = false;
            getProjects();
            if (project > 1)
            {
                buttonBackToMain.Visible = true;
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
        
        private void listBox_projects_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox_projects.SelectedIndex != -1)
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
                project = listBox_projects.SelectedIndex + 2;
                int k = listBox_projects.SelectedIndex + 2;
                buttonBackToMain.Visible = true;
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "SELECT * from tasks where project_id = '" + k + "';";
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

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            if (project>1)
            {
                project = 1;
                buttonBackToMain.Visible = false;
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
            if (project > 1){
                MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
                using (mySql)
                {
                    mySql.Open();
                    MySqlCommand command = new MySqlCommand("select * from tasks where task_name like '%" + searh_text + "%' and project_id='"+project+"'", mySql);
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
                    MySqlCommand command = new MySqlCommand("select * from tasks where task_name like '%" + searh_text + "%'", mySql);
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
    }
}
