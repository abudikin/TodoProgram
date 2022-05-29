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
    public partial class TaskControl : UserControl
    {
        int index;
       
        public TaskControl(int id, string text, string description, string date, int priority, int project)
        {
            InitializeComponent();
            taskText.Text = text;
            labelDescription.Text = description;
            labelDay.Text = date;
            index = id;
            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from projects where project_id='" + project + "'", mySql);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        labelProjectName.Text = reader[1].ToString();
                    }
                    reader.Close();
                }
                mySql.Close();
            }
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("select * from priority where priority_id='" + priority + "'", mySql);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        PriorityText.Text = reader[1].ToString();
                    }
                    reader.Close();
                }
                mySql.Close();
            }
        }
       
        private void TaskControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 40, 40);
        }

        private void TaskControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("delete from tasks where task_id='"+index+"'", mySql);
                command.ExecuteNonQuery();
            }
            mySql.Close();
            taskText.Text = "Удален";

        }

        private void TaskControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*FormTaskShow formTask = new FormTaskShow(index,pr);
            formTask.Show();*/
        }
    }
}
