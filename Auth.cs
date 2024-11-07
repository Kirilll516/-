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
    public partial class Auth : Form
    {
        private string connectionString = "Data Source = DESKTOP-MQR04MO SQLEXPRESS; Initial Catalog = test1; Integrated Security = True; Encrypt = False";

        SqlConnection SqlConnection = new SqlConnection();


        private object checkBox;

        public Auth()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Если CheckBox отмечен, показываем пароль
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                // Если CheckBox не отмечен, скрываем пароль
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы
            menu form2 = new menu();
            // Показываем вторую форму
            
            form2.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Reg form2 = new Reg();
         
            form2.Show();
            this.Hide();
        }
    }
}
