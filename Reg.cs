using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая1._3
{
    public partial class Reg : Form
    {


        public Reg()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Если CheckBox отмечен, показываем пароль
                textBox8.UseSystemPasswordChar = false;
            }
            else
            {
                // Если CheckBox не отмечен, скрываем пароль
                textBox8.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Можно вернуться к первой форме, если нужно
            menu form3 = new menu();
            form3.Show();
            this.Hide();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Если символ не цифра и не управляющий, отменяем его ввод
                e.Handled = true;
            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu form3 = new menu();
            form3.Show();
            this.Hide();
        }
    }
}
