using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_FormApp
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }


        double firstNumber = 0, secondNumber = 0, result = 0;
        bool control = false;
        string messageBox = "Please enter the numbers";

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Paramenter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Paramenter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Abs(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Sin(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Cos(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Tan(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Paramenter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Pow(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Sqrt(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Paramenter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Log(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)).ToString();
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Log10(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Paramenter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                txtResult.Text = Math.Exp(Convert.ToDouble(firstNumber)).ToString();
            }
        }

        private void btnCopyFirstNumber_Click(object sender, EventArgs e)
        {
            if(txtResult.Text.Trim() != "")
            {
                txtFirstNumber.Text = txtResult.Text;
                txtResult.Clear();
                txtSecondNumber.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void set1Paramenter(string text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }

        void set2Paramenter(string text, string text2)
        {
            if (text.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }
            else
            {
                control = false;
            }
        }
    }
}
