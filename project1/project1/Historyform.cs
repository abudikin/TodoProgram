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
    public partial class Historyform : Form
    {
        
        public Historyform()
        {
            InitializeComponent();
            getTargets();
        }
        int pos = 10;
        public void additem(string text)
        {
            //panelform form = new panelform();
            Historytable item = new project1.Historytable(text);
            panel1.Controls.Add(item);
            item.Top = pos;
            pos = (item.Top + item.Height + 10);

        }




        public void getTargets()
        {
            
            
                NpgsqlConnection npgsql = new NpgsqlConnection(@"Server=localhost;Port=5432;User id=postgres;Password=1234;DataBase=TestBD");
                using (npgsql)
                {

                    npgsql.Open();
                    NpgsqlCommand command = new NpgsqlCommand("select * from old_task", npgsql);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            additem("" + reader["name"]);
                        }
                    }
                   
            }
        }
       
        public void buttonHistoryClose_Click(object sender, EventArgs e)
        {   
            
            
            this.Hide();
            Список_дел list = new Список_дел();
            list.Show();

        }
    }
}
