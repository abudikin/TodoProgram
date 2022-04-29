using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace project1
{
    public partial class task_table : UserControl
    {
        public task_table(string text)
        {
            InitializeComponent();
            task_text.Text = text;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
            using (npgsql)
            {
                npgsql.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("insert into old_task where name='" + task_text.Text + "'", npgsql);
                NpgsqlCommand command = new NpgsqlCommand("delete from current_tasks where name='" + task_text.Text + "'", npgsql);
                command.ExecuteNonQuery();
            }
            task_text.Text = "удален";
                
        }

        
    }
}

