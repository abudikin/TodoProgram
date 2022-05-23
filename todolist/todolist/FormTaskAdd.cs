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
        public FormTaskAdd()
        {
            InitializeComponent();
        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                string text = textBox1.Text;
                int priority = Convert.ToInt32(comboBoxPriority.SelectedItem);
                int sub_task = 1;
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "INSERT INTO tasks(task_name, date, priority, sub_task_id) " +
                             "VALUES('" + text + "','" + dateTimePicker1.Value.Date.ToString("dd.MM.yyyy")+ "','" + priority + "','" + sub_task + "');";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Добавлено");
                conn.Close();


            }
        }

        private void FormTaskAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
