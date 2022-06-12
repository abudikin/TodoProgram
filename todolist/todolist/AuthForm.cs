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
    public partial class AuthForm : Form
    {
        int user_id;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLoginName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from user where login = '" + textBoxLoginName.Text + "' and password ='" + textBoxPassword.Text + "'", mySql);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                using (mySql)
                {
                    if (table.Rows.Count > 0)
                    {
                        
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user_id = Convert.ToInt32(reader[0]);
                            }
                        }
                        MessageBox.Show("Успешно");
                        FormMain formMain = new FormMain(user_id);
                        this.Hide();
                        formMain.Show();
                    }
                    else MessageBox.Show("Ошибка авторизации");
                    mySql.Close();

                }
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }
    }
}
