using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operation = "";
        bool operator_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox1_result.Text = textBox1_result.Text + "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1_result.Text = textBox1_result.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  textBox1_result.Text = textBox1_result.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //  textBox1_result.Text = textBox1_result.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // textBox1_result.Text = textBox1_result.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //  textBox1_result.Text = textBox1_result.Text + ".";
        }

        private void button15_Click(object sender, EventArgs e)  //for CE button
        {
            if (textBox1_result.Text == "")
            {

            }
            else
            {
                textBox1_result.Text = textBox1_result.Text.Remove(textBox1_result.Text.Length - 1, 1);
            }


        }

        private void button_Click(object btn, EventArgs e)  // for button click
        {

            if ((textBox1_result.Text == "0") || (operator_pressed))
            {
                textBox1_result.Clear();
            }
            operator_pressed = false;

            Button b = (Button)btn;
            if (b.Text == ".")
            {
                if (!textBox1_result.Text.Contains("."))
                    textBox1_result.Text = textBox1_result.Text + b.Text;

            }
            else
            {
                if (textBox1_result.Text.Length == 10)
                {

                }
                else
                {
                    textBox1_result.Text = textBox1_result.Text + b.Text;
                }
            }

        }

       
    private void Operation_Click(object btn, EventArgs e)// for operators
        {
            try
            {
                Button b = (Button)btn;
            operation = b.Text;
            resultValue = Double.Parse(textBox1_result.Text);
            label1.Text = resultValue + " " + operation;
            operator_pressed = true;
        }
            catch(Exception ex)
            {
                MessageBox.Show("Enter Numbers first for operation "); 
            }
    }

        private void button18_Click(object sender, EventArgs e)// for operations
        {

            operator_pressed = false;

                switch (operation)
                {
                    case "+":
                        textBox1_result.Text = (resultValue + Double.Parse(textBox1_result.Text)).ToString();
                        break;

                    case "-":
                        textBox1_result.Text = (resultValue - Double.Parse(textBox1_result.Text)).ToString();
                        break;
                    case "*":
                        textBox1_result.Text = (resultValue * Double.Parse(textBox1_result.Text)).ToString();
                        break;
                    case "/":
                        textBox1_result.Text = (resultValue / Double.Parse(textBox1_result.Text)).ToString();
                        break;
                }
                label1.Text = "";
           
        }
        private void button16_Click(object sender, EventArgs e) // for C button
        {
            textBox1_result.Text = "0";
            resultValue = 0;
        }

        private void Key_press(object btn, KeyPressEventArgs e)
        {
            if ((textBox1_result.Text == "0") || operator_pressed)
            {
                textBox1_result.Clear();
            }
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled = true;
            }

        }
    }
}
