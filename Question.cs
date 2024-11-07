using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсовая1._3
{
    public partial class Question : Form
    {
        private string connectionString = @"Data Source = DESKTOP-MQR04MO SQLEXPRESS; Initial Catalog = master2; Integrated Security = True; Encrypt = False";

        SqlConnection SqlConnection = new SqlConnection();

        public Question()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

