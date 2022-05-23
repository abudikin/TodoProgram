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
        public TaskControl(string text,int id,int p)
        {
            InitializeComponent();
            taskText.Text = text;
            index = id;
            
            PriorityText.Text = p.ToString();
        }
       
        private void TaskControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void TaskControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
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
            taskText.Text = "Удален";

        }
    }
}
