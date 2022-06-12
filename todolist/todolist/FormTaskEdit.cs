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
    public partial class FormTaskEdit : Form
    {
        int index;
        int project_id, priority_id;
        public FormTaskEdit(int id,string task,string description,string date,int project,int priority)
        {
            InitializeComponent();
            index = id;
            textBoxTaskEdit.Text = task;
            textBoxDesckiptionEdit.Text = description;
            dateTimePicker1.Value = Convert.ToDateTime(date);
            project_id = project;
            priority_id = priority;

        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            string taskEdit = textBoxTaskEdit.Text;
            string deskriptionEdit = textBoxDesckiptionEdit.Text;
            int priority = Convert.ToInt32(comboBoxEditPriority.SelectedValue);
            int projectId = Convert.ToInt32(comboBoxEditProject.SelectedValue);

            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("update tasks set task_name='"+taskEdit+"',date='"
                    + dateTimePicker1.Value.Date.ToString("yyyy.MM.dd") + 
                    "',description='" + deskriptionEdit + "',priority_id='"+priority+ "',project_id='" 
                    + projectId + "' where task_id='" + index + "'", mySql);
                command.ExecuteNonQuery();
               MessageBox.Show("Изменено");
                mySql.Close();
            }
        }

        private void FormTaskShow_Load(object sender, EventArgs e)
        {
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                DataTable priorityTable = new DataTable();
                MySqlCommand command = new MySqlCommand("select * from priority", mySql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(priorityTable);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxEditPriority.DataSource = priorityTable;
                        comboBoxEditPriority.DisplayMember = "priority_name";
                        comboBoxEditPriority.ValueMember = "priority_id";
                        comboBoxEditPriority.SelectedValue = priority_id;

                    }
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
                        comboBoxEditProject.SelectedValue = project_id;
                    }
                }
                mySql.Close();
            }
        }
    }
}
