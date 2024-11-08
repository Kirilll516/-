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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая1._3
{
    
    public partial class Reg : Form
    {
        private string connectionString = "Data Source = Cab109,49172; Initial Catalog = master2; Integrated Security = True; Encrypt = False";

        public Reg()
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
            string email    = textBox3.Text;
            if (ValidateUser(username, password,email))
            {
                MessageBox.Show("Вы зарегались", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu form = new menu();
                this.Hide();
                form.Show();
            }
            
        }
        private bool ValidateUser(string login, string password, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO users (login,Password,Email) VALUES (@login,@Password,@Email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return (count == 1);
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Если символ не цифра и не управляющий, отменяем его ввод
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu form3 = new menu();
            form3.Show();
            this.Hide();
        }

        
    }
}
