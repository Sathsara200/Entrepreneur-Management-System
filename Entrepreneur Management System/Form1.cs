using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrepreneur_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin123")
            {
                MessageBox.Show("Welcome Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm1 = new Form2();
                frm1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to exit", "EXIT",
                     MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
