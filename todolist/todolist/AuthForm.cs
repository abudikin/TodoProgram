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
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLoginName.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
                using (mySql)
                {
                    mySql.Open();
                    MySqlCommand command = new MySqlCommand("select * from user where login = '" + textBoxLoginName + "' and password ='"+textBoxPassword+"'", mySql);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                    mySql.Close();
                }



            }
        }
    }
}
