using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        static int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int n1 = int.Parse(textBox2.Text);
            Random r = new Random();
            label7.Text = r.ToString();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object btn, EventArgs e)
        {

        }

        //private void btnstart(object sender, EventArgs e)
        //{

        //}

        

        private void btnstart_Click(object sender, EventArgs e)
        {
            time.Start();
            Random r = new Random();
            Random m = new Random();
            int maxr = 10;
            int maxm = 10;
            int numr = r.Next(2, maxr);
            int numm = m.Next(4, maxm);
            int total = (numr + numm);
            textBox1.Text = r.Next(2, maxr).ToString();
            textBox2.Text = m.Next(2, maxm).ToString();
            label7.Text = total.ToString();
            //int numm = m.Next(4, maxm);
            //textBox1.Text = r.Next().ToString();
            //textBox2.Text = r.Next().ToString();
            //label7.Text = textBox1.Text + textBox2.Text;
            //textBox3.Text = r.Next().ToString();
            //textBox4.Text = r.Next().ToString();
            //label7.Text = textBox3.Text + textBox4.Text;
            //textBox5.Text = r.Next().ToString();
            //textBox6.Text = r.Next().ToString();
            //label7.Text = textBox5.Text * textBox6.Text;

            //textBox7.Text = r.Next().ToString();
            //textBox8.Text = r.Next().ToString();
            //label7.Text = textBox7.Text / textBox8.Text;

        }
        private void time_Tick(object sender, EventArgs e)
        {
            time.Stop();
            if (i > 1)
            {
                labeltext.Text = i.ToString() + "seconds remainig";
            }
            else if (i == 1)
            {
                labeltext.Text = i.ToString() + "second remainig";
            }
            else
            {
              
                labeltext.Text = "You have only 30 Seconds";
                MessageBox.Show("TIME OUT:(", "TIME OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                i = 30;
            }
            i--;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            //textBox1.Text = r.Next().ToString();
            //textBox2.Text = r.Next().ToString();
            //textBox3.Text = r.Next().ToString();
            //textBox4.Text = r.Next().ToString();
            //textBox5.Text = r.Next().ToString();
            //textBox6.Text = r.Next().ToString();
            //textBox7.Text = r.Next().ToString();
            //textBox8.Text = r.Next().ToString();
        }
    }
}
