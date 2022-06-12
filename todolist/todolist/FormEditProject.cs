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
    public partial class FormEditProject : Form
    {
        int project_id;
        public FormEditProject(int project,string projectText)
        {
            InitializeComponent();
            project_id = project;
            textBoxProjectEdit.Text = projectText;
        }

        private void buttonEditProject_Click(object sender, EventArgs e)
        {
            string projectEdit = textBoxProjectEdit.Text;

            MySqlConnection mySql = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=todo");
            using (mySql)
            {
                mySql.Open();
                MySqlCommand command = new MySqlCommand("update projects set project_name='" + projectEdit + 
                    "' where project_id='" + project_id + "'", mySql);
                command.ExecuteNonQuery();
                MessageBox.Show("Изменено");
                mySql.Close();
            }
           
        }
    }
}
