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
    public partial class RegForm : Form
    {
        bool k;
        public RegForm()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length != 0 || textBoxName.Text.Length != 0 || textBoxPassword.Text.Length != 0 || textBoxSurname.Text.Length != 0)
            {
                check();
                if (k == false)
                {
                    string login = textBoxLogin.Text;
                    string name = textBoxName.Text;
                    string surname = textBoxSurname.Text;
                    string password = textBoxPassword.Text;
                    string connStr = "server=localhost; port=3306; username=root; password=root; database=todo;";
                    string sql = "INSERT INTO user(name, surname,login, password) " +
                                 "VALUES('" + name + "','" + surname + "','" + login + "','" + password + "');";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    conn.Open();
                    MessageBox.Show("Добавлено");
                    AuthForm authForm = new AuthForm();
                    authForm.Show();
                    this.Hide();
                    conn.Close();
                }
                else 
                {
                    MessageBox.Show("Такой логин уже существует");
                    textBoxLogin.Clear();
                }

            }

        }
        public void check()
        {
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from user", mySql);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (textBoxLogin.Text == reader[3].ToString())
                        {
                            k = true;
                        }
                        else k = false;
                    }
                }
                mySql.Close();
            }
        }
    }
}
