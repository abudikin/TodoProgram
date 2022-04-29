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
    public partial class Список_дел : Form
    {
        public Список_дел()
        {
            InitializeComponent();
        }

        

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();  
            
        }

        /*private void refreshor_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }*/

        public void button_history_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historyform list = new Historyform();
            list.Show();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearch list2 = new FormSearch();
            list2.Show();
        }
    }
}
