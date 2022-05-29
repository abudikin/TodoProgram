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
    public partial class FormTaskShow : Form
    {
        int index;
        int pr;
        public FormTaskShow(int id,int p)
        {
            InitializeComponent();
            index = id;
            pr = p;
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            string taskEdit = textBoxTaskEdit.Text;
            string deskriptionEdit = textBoxDesckiptionEdit.Text;
            int priority = Convert.ToInt32(comboBoxEditPriority.SelectedItem);
            int subtaskId = 1;
            int projectId = Convert.ToInt32(comboBoxEditProject.SelectedIndex);

            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("update tasks set task_name='"+taskEdit+"',date='"+ dateTimePicker1.Value.Date.ToString("yyyy.MM.dd") + "',priority='"+ priority + "',description='"+ deskriptionEdit + "',subtask_id='"+subtaskId+"',project_id='"+projectId+"' where task_id='"+ index + "'", mySql);
                command.ExecuteNonQuery();
               MessageBox.Show("Изменено");
                mySql.Close();
            }
        }

        private void FormTaskShow_Load(object sender, EventArgs e)
        {
            comboBoxEditPriority.Text = pr.ToString();
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from tasks,projects where task_id='" + index + "'", mySql);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        textBoxTaskEdit.Text = reader[1].ToString();
                        textBoxDesckiptionEdit.Text = reader[4].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader[2]);
                    }reader.Close();
                }
                mySql.Close();
            }
            using (mySql)
            {
                mySql.Open();
                DataTable patientTable = new DataTable();
                MySqlCommand command = new MySqlCommand("select * from projects", mySql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(patientTable);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxEditProject.DataSource = patientTable;
                        comboBoxEditProject.DisplayMember = "project_name";

                        comboBoxEditProject.ValueMember = "project_id";
                        comboBoxEditProject.Text = reader[1].ToString(); 



                    }
                }
                mySql.Close();
            }
        }
    }
}
