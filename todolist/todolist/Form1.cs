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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getTargets();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        void getTargets()
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


                        additem(reader[1].ToString(),Convert.ToInt32(reader[0]), Convert.ToInt32(reader[3]));

                    }
                }
            }



        }
        
        public void additem(string text,int id,int priority)
        {
           
                TaskControl item = new TaskControl(text,id,priority);
                MainPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                label_empty.Hide();
            
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormTaskAdd formTaskAdd = new FormTaskAdd();
            formTaskAdd.Show();
            this.Hide();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            getTargets();
        }
    }
}
