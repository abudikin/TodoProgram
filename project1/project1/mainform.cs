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
    public partial class mainform : UserControl
    {
        
        public mainform()
        {
            InitializeComponent();
            getTargets();
            
        }
        int pos = 10;
        public void additem(string text)
        {
            task_table item = new project1.task_table(text);      
            mainpanek.Controls.Add(item);
            item.Top = pos;
            pos = (item.Top + item.Height + 10);
            

        }
        private void mainbutton_Click(object sender, EventArgs e)
        {

            if (checkTask())
                return;
            if (maintext.Text == "")
            {
                MessageBox.Show("Задача не добавлена");
                return;
            }
            Data db = new Data();
           NpgsqlCommand command = new NpgsqlCommand("INSERT INTO current_tasks(name) VALUES (@task)", db.GetConnection());
            NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO old_tasks(name) VALUES (@name)", db.GetConnection());
            
            command.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = maintext.Text;
            command2.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = maintext.Text;

           // db.openconnection();
            //if (command.ExecuteNonQuery() == 1)
            //{   
               
                string tarName = maintext.Text;
                //string daname = maintext.Text;
                additem(tarName);
               
                addTargets(tarName);
                //addTargets(daname);
                maintext.Text = "";
                MessageBox.Show("Задача добавлена");

            //}


          // else
               // MessageBox.Show("Задача не добавлена");
           // db.closeconnection();
        }


        
        public Boolean checkTask()
        {
            Data db = new Data();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM current_tasks where name = @task", db.GetConnection());
            command.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = maintext.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая задача уже существует");
                return true;
            }
            else
                return false;
        }

        void getTargets()
        {
            
                NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
                using (npgsql)
                {
                    npgsql.Open();
                    NpgsqlCommand command = new NpgsqlCommand("select * from current_tasks", npgsql);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            
                             additem("" + reader["name"]);
                            
                            
                        }
                    }
                }
                

            
        }
        public void addTargets(string insert) 
        {
            //count = 1;
            NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
            using (npgsql) 
            {
                npgsql.Open();
                NpgsqlCommand commandsec = new NpgsqlCommand("INSERT INTO current_tasks (name) values ('"+ insert +"')",npgsql);
                NpgsqlCommand commandthird = new NpgsqlCommand("INSERT INTO old_task (name) values ('" + insert + "')",npgsql);
                commandsec.ExecuteNonQuery();
                commandthird.ExecuteNonQuery();
            }
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            mainpanek.Controls.Clear();
            pos = 10;
            getTargets();
        }

        private void buttonref_Click(object sender, EventArgs e)
        {
            Formref lis = new Formref();
            lis.Show();
        }
    }

}

