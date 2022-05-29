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
    public partial class FormTaskAdd : Form
    {
        int index;
        public FormTaskAdd(int id)
        {
            InitializeComponent();
            index = id;
        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            if (textBoxTask.Text =="" && comboBoxPriority.SelectedIndex==-1 && comboBoxProject.SelectedIndex==-1)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                string task = textBoxTask.Text;
                string description = textBoxDescription.Text;
                int priority = Convert.ToInt32(comboBoxPriority.SelectedIndex)+1;
                int status = 1;
                int project_id = Convert.ToInt32(comboBoxProject.SelectedIndex)+1;
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "INSERT INTO tasks(task_name, date,description, status_id, priority_id,project_id) " +
                             "VALUES('" + task + "','" + dateTimePicker1.Value.Date.ToString("yyyy.MM.dd")+ "','"+ description + "','" + status + "','" + priority + "','" + project_id + "');";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Добавлено");
                conn.Close();
                


            }
        }

        private void FormTaskAdd_Load(object sender, EventArgs e)
        {
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
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
                        comboBoxProject.DataSource = patientTable;
                        comboBoxProject.DisplayMember = "project_name";
                        comboBoxProject.ValueMember = "project_id";
                        comboBoxProject.Text = reader[1].ToString();
                    }
                }
                mySql.Close();
            }
        }
    }
}
