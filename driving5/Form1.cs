using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace driving5
{
    public partial class Form1 : Form
    {   
        int correctAns;
        public Form1()
        {
            InitializeComponent();
            QuestionChooser();
        }

        private void QuestionChooser()
        {
            Random r = new Random();
            int qnum = r.Next(1, 25);

            if (qnum == 1)
            {
                label1.Text = "Правилата за движение в населено място се прилагат:";
                button1.Text = "по всички участъци от пътя, по които се движат пешеходци";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 2)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 3)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 4)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 5)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 6)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 7)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 8)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 9)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 10)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 11)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 12)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 13)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 14)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 16)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 17)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 18)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 19)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 20)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 21)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 22)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 23)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 24)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else if (qnum == 25)
            {
                label1.Text = "";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1111";
        }
    }
}
