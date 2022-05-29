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
    public partial class FormAddProject : Form
    {
        public FormAddProject()
        {
            InitializeComponent();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                string text = textBox1.Text;
                
                string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                string sql = "INSERT INTO projects(project_name) " + "VALUES('" + text + "');";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                conn.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Добавлено");
                conn.Close();



            }
        }

       
    }
}
