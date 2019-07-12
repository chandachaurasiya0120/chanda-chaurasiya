using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomandtimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Random M = new Random();
            Random N = new Random();
            int maxM = 10;
            int maxN = 10;
            int numM = M.Next(2, maxM);             //For addition
            int numN = N.Next(4, maxN);
            int numTotal = (numM + numN);
            firstNumber.Text = numM.ToString();
            secondNumber.Text = numN.ToString();
            totalNumber.Text = numTotal.ToString();
            Random R = new Random();
            Random S = new Random();
            int maxR = 20;
            int maxS = 10;
            int numR = M.Next(2, maxR);
            int numS = N.Next(4, maxS);
            int numT = (numR - numS);           //For subtraction
            label5.Text = numR.ToString();
            label3.Text = numS.ToString();
            label2.Text = numT.ToString();
            Random A = new Random();
            Random B = new Random();
            int maxA = 10;
            int maxB = 10;
            int numA = A.Next(2, maxA);
            int numB = B.Next(4, maxB);
            int Total = (numA * numB);           //For multiplication
            label10.Text = numA.ToString();
            label8.Text = numB.ToString();
            label7.Text = Total.ToString();
            Random J = new Random();
            Random K = new Random();
            int maxJ = 20;
            int maxK = 10;
            int numJ = J.Next(2, maxJ);
            int numK = K.Next(4, maxK);
            int T = (numJ / numK);           //For division
            label14.Text = numJ.ToString();
            label12.Text = numK.ToString();
            label11.Text = Total.ToString();

        }
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            timer1.Stop();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            msg.Visible = true;
            label1.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            if (textBox1.Text == totalNumber.Text)
            {
                msg.Text = "correct answer!!..";            //Addition

            }
            else
            {
               msg.Text = "wrong answer!!.";
            }
            if (textBox2.Text == label2.Text)
            {
                label1.Text = "correct answer!!..";            //subtraction

            }
            else
            {
                label1.Text = "wrong answer!!.";
            }
            if (textBox3.Text == label7.Text)
            {
                label6.Text = "correct answer!!.";            //multiplication

            }
            else
            {
                label6.Text = "wrong answer!!.";
            }
            if (textBox4.Text == label11.Text)
            {
                label9.Text = "correct answer!!.";            //division

            }
            else
            {
                label9.Text = "wrong answer!!.";
            }
        }
    
       
        int timeleft = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft >=0)
            {
                btnSubmit.Enabled = true;
                timeleft = timeleft-1;
                lbltimer.Text = timeleft + " seconds remaining";
                btnrefresh.Visible =false;

            }
            else
            {
                btnSubmit.PerformClick();
                btnSubmit.Enabled = false;
                btnrefresh.Visible = true;
                button1.Visible = false;
               lbltimer.Text = "sorry!!..Time Out";

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            firstNumber.Text = null;
            secondNumber.Text = null;
            totalNumber.Text = null;
            label5.Text = null;
            label3.Text = null;
            label2.Text = null;
            label10.Text = null;
            label8.Text = null;
            label7.Text = null;
            label14.Text = null;
            label12.Text = null;
            label11.Text = null;
            msg.Text = "Result!!.";
            label1.Text = "Result!!.";
            label6.Text = "Result!!.";
            label9.Text = "Result!!.";
            timeleft = 31;
            timer1.Start();
            textBox1.Enabled =true;
            textBox2.Enabled =true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            Random M = new Random();
            Random N = new Random();
            int maxM = 10;
            int maxN = 10;
            int numM = M.Next(2, maxM);             //For addition
            int numN = N.Next(4, maxN);
            int numTotal = (numM + numN);
            firstNumber.Text = numM.ToString();
            secondNumber.Text = numN.ToString();
            totalNumber.Text = numTotal.ToString();
            Random R = new Random();
            Random S = new Random();
            int maxR = 20;
            int maxS = 10;
            int numR = M.Next(2, maxR);
            int numS = N.Next(4, maxS);
            int numT = (numR - numS);           //For subtraction
            label5.Text = numR.ToString();
            label3.Text = numS.ToString();
            label2.Text = numT.ToString();
            Random A = new Random();
            Random B = new Random();
            int maxA = 10;
            int maxB = 10;
            int numA = A.Next(2, maxA);
            int numB = B.Next(4, maxB);
            int Total = (numA * numB);           //For multiplication
            label10.Text = numA.ToString();
            label8.Text = numB.ToString();
            label7.Text = Total.ToString();
            Random J = new Random();
            Random K = new Random();
            int maxJ = 20;
            int maxK = 10;
            int numJ = J.Next(2, maxJ);
            int numK = K.Next(4, maxK);
            int T = (numJ / numK);           //For division
            label14.Text = numJ.ToString();
            label12.Text = numK.ToString();
            label11.Text = Total.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
