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
        private string connectionString = "Data Source = Cab109,49172; Initial Catalog = master2; Integrated Security = True; Encrypt = False";

         


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
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (ValidateUser(username, password))
            {
                MessageBox.Show("Вы вошли в свой аккаунт", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu form = new menu();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Reg form2 = new Reg();
         
            form2.Show();
            this.Hide();


        }

        private bool ValidateUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM users WHERE login = @login and Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return (count == 1);
                }
            }
        }
    }
}
