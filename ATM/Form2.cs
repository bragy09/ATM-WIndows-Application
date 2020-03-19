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
    public partial class Form2 : Form
    {
        Form1 modify = new Form1();
        double balance = 2000;
        string choose;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox4.Text = textBox4.Text + button.Text;
        }

        private void btncancel_clear(object sender, EventArgs e)
        {
            textBox4.Clear();
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

        }

        private void btnclear_click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void btnenter_click(object sender, EventArgs e)
        {
            if (choose == "Deposit")
            {
                if (Int64.Parse(textBox4.Text) < 1)
                {
                    MessageBox.Show("Amount Is Invalid");
                    textBox4.Clear();
                }
                else if (Int64.Parse(textBox4.Text) > 1000)
                {
                    MessageBox.Show("Amount Is Too High");
                    textBox4.Clear();
                }
                else
                {

                    balance += Int64.Parse(textBox4.Text);
                    MessageBox.Show("Amount Is Successfully Deposited");
                    textBox4.Clear();
                }
            }


            else if (choose == "Renew")
            {
                if (Int64.Parse(textBox4.Text) == modify.pin)
                {
                    textBox4.Clear();

                    label6.Text = "New PIN";

                    choose = "N";
                }
                else
                {
                    MessageBox.Show("invalid PIN!, Try again!");
                }
            }
            else if (choose == "N")
            {
                modify.pin = Int32.Parse(textBox4.Text);
                MessageBox.Show("PIN Has Been Changed successfully ");
                textBox4.Clear();
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;

            }
            else if (choose == "Withdraw")
            {
                if (balance < 100)
                {
                    MessageBox.Show("Transaction Failed, Not Enough Money");
                    textBox4.Clear();
                }
                else if (Int64.Parse(textBox4.Text) < 1)
                {
                    MessageBox.Show("Invalid Amount!!");
                    textBox4.Clear();
                }
                else if (Int64.Parse(textBox4.Text) > balance)
                {
                    MessageBox.Show("Not Enough Money, Invalid Amount");
                    textBox4.Clear();
                }
                else
                {
                    if ((balance - Int64.Parse(textBox4.Text)) < 100)
                    {
                        MessageBox.Show("Min is $100, Transaction Faild!");
                        textBox4.Clear();
                    }
                    else
                    {
                        balance -= Int64.Parse(textBox4.Text);
                        MessageBox.Show("Amount Successfully Transferred !!");
                        textBox4.Clear();

                    }
                }
            }
        }
        private void btnmpty_click(object sender, EventArgs e)
        {
            if(textBox4.Text.Length>0)
            {
                textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            label3.Text = "Name:";
            label3.Visible = true;
            label4.Text = "Type";
            label4.Visible = true;
            label5.Text = "Phone";
            label5.Visible = true;
            label6.Text = "Address";
            label6.Visible = true;
            textBox1.Text = "Kamal Al Nasr";
            textBox1.Visible = true;
            textBox2.Text = "Checking**1234";
            textBox2.Visible = true;
            textBox3.Text = "(615) 963- 5848";
            textBox3.Visible = true;
            textBox4.Text = "3500 John A. Merritt Ave. Nashville,Tn 37209.";
            textBox4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label3.Text = "Balance:";
            label4.Text = string.Format(" Your Balance is: ${0}  ", balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            label3.Text = "Change PIN:";
            label6.Text = "OLD PIN";
            choose = "Renew";
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            label3.Text = "Deposite Amount Below:";
            label6.Text = "Amount:";
            choose = "Deposit";
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            label3.Text = "Withdraw Amount Below:";
            label6.Text = "Amount:";
            choose = "Withdraw";
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balance < 200)
            {
                MessageBox.Show("Not Enough Money!!");
            }
            else
            {
                balance = balance - 100;
                MessageBox.Show("$100 Has Been Successfully Withdrawn.");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
