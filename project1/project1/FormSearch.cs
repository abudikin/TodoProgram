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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        int pos = 10;
        public void additem(string text)
        {
            task_table item = new project1.task_table(text);
            panelSearch.Controls.Add(item);
            item.Top = pos;
            pos = (item.Top + item.Height + 10);


        }
        public void getTargets()
        {
            NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
            using (npgsql)
            {
                npgsql.Open();
                NpgsqlCommand command = new NpgsqlCommand("select name from current_tasks where name = @task", npgsql);
                command.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxSearch.Text;
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {


                        additem("" + reader["name"]);


                    }
                }
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Data db = new Data();
            NpgsqlCommand command = new NpgsqlCommand("select name from current_tasks where name like '%@task%'", db.GetConnection());
            command.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = textBoxSearch.Text;
            panelSearch.Controls.Clear();
            pos = 10;
            getTargets();
        }

        private void buttonSearchExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Список_дел list = new Список_дел();
            list.Show();
        }
    }
}
