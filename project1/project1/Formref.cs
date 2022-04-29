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
    public partial class Formref : Form
    {
        public Formref()
        {
            InitializeComponent();
        }

        private void buttoExitRef_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcceptRef_Click(object sender, EventArgs e)
        {
            string name = textBoxPrev.Text;
            string task = textBoxRef.Text;
            Data dt = new Data();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("update current_tasks set name=(@name) where name=(@task)",dt.GetConnection());
            NpgsqlCommand command2 = new NpgsqlCommand("update old_task set name = (@name) where name = (@task)", dt.GetConnection());
            command.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = task;
            command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name;
            command2.Parameters.Add("@task", NpgsqlTypes.NpgsqlDbType.Varchar).Value = task;
            command2.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name;

            adapter.SelectCommand = command;
            adapter.SelectCommand = command2;




        }
    }
}
