using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсовая1._3
{
    public partial class Question : Form
    {
        private string connectionString = "Data Source = Cab109,49172; Initial Catalog = master2; Integrated Security = True; Encrypt = False";

        SqlConnection SqlConnection = new SqlConnection();

        public Question()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT inCorrect FROM Question WHERE inCorrect = 1", connection);
                if(command.Parameters.Count == 1)
                {
                    Question2 question2 = new Question2();
                    question2.Show();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    }
}

