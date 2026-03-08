using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace TP_MODUL3_103022400028
{
    public partial class Calculator : Form
    {
        double nilai1 = 0;
        string operasi = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToDouble(Output.Text);
            operasi = "+";
            Output.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double nilai2 = Convert.ToDouble(Output.Text);
            if (operasi == "+")
            {
                Output.Text = (nilai1 + nilai2).ToString();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
