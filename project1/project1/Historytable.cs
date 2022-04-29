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
    public partial class Historytable : UserControl
    {
        public Historytable(string text)
        {
            InitializeComponent();
            historytext.Text = text;

        }

        private void buttonclean_Click(object sender, EventArgs e)
        {
            NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
            using (npgsql)
            {
                npgsql.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from old_task where name='" + historytext.Text + "'", npgsql);
                command.ExecuteNonQuery();


            }
            historytext.Text = "удален";
        }
    }
}
