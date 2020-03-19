using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public int pin = 3300;
        public Form1()
           
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3300")
            {
                // MessageBox. show ("your pin is correct");
                Form2 Form2 = new Form2();
                Form2.Show();
            }
            else
            {
                MessageBox.Show("PIN IS INVALID");
                textBox1.Clear();
            }
            }

        private void btncancel_click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btnclear_click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

