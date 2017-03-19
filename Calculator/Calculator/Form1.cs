using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string first = string.Empty;
        string second = string.Empty;
        string input = string.Empty;
        double result = 0.0;
        char operation;


        public Form1()
        {
            InitializeComponent();
        }


        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 2;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 3;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 4;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 5;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 6;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 7;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 8;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 9;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 0;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (LabelBox.Text.Contains("."))
            {

            }
            else
            {
                this.LabelBox.Text = "";
                input += ".";
                this.LabelBox.Text += input;
                label1.Focus();
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if(first == string.Empty)
            {
                first = input;
                operation = '+';
                input = string.Empty;
                label1.Focus();
            }
            else
            {
                second = input;
                operation = '+';
                label1.Focus();
                EqualsButton.PerformClick();
            }
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            /*first = input;
            operation = '-';
            input = string.Empty;
            label1.Focus();*/
            if (first == string.Empty)
            {
                first = input;
                operation = '-';
                input = string.Empty;
                label1.Focus();
            }
            else
            {
                second = input;
                operation = '-';
                label1.Focus();
                EqualsButton.PerformClick();
            }
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            if (first == string.Empty)
            {
                first = input;
                operation = 'X';
                input = string.Empty;
                label1.Focus();
            }
            else
            {
                second = input;
                operation = 'X';
                label1.Focus();
                EqualsButton.PerformClick();
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (first == string.Empty)
            {
                first = input;
                operation = '/';
                input = string.Empty;
                label1.Focus();
            }
            else
            {
                second = input;
                operation = '/';
                label1.Focus();
                EqualsButton.PerformClick();
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            first = string.Empty;
            LabelBox.Text = "0";
            label1.Focus();

        }

        private void OneButton_Click_1(object sender, EventArgs e)
        {
            this.LabelBox.Text = "";
            input += 1;
            this.LabelBox.Text += input;
            label1.Focus();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            second = input;
            double firstd;
            double secondd;
            double.TryParse(first, out firstd);
            double.TryParse(second, out secondd);

            switch (operation)
            {
                case ('+'):
                    result = firstd + secondd;
                    this.LabelBox.Text = result.ToString();
                    break;
                case ('/'):
                    if (secondd == 0)
                    {
                        LabelBox.Text = "Cannot Divide by 0";
                        break;
                    }
                    else
                    {
                        result = (double)firstd / secondd;
                        this.LabelBox.Text = result.ToString();
                        break;
                    }
                case ('-'):
                    result = firstd - secondd;
                    this.LabelBox.Text = result.ToString();
                    break;
                case ('X'):
                    result = firstd * secondd;
                    this.LabelBox.Text = result.ToString();
                    break;

            }

            //first = string.Empty;
            //doesnt work if someone adds after calculation
            first = result.ToString();
            second = string.Empty;
            input = string.Empty;
            label1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BinaryButton_CheckedChanged(object sender, EventArgs e)
        {
            //button clicks change here
            //have to make own methods; onebinary to decimal and decimal to binary

            if (BinaryButton.Checked)
            {
                int decim;
                int.TryParse(LabelBox.Text, out decim);
                int remainder;
                string res = string.Empty;
                while (decim > 0)
                {
                    remainder = decim % 2;
                    decim = decim / 2;
                    res = remainder.ToString() + res;
                }
                LabelBox.Text = res;

            }

            if(DecimalButton.Checked)
            {
                string bin = this.LabelBox.Text;
                int binnum;
                int.TryParse(bin, out binnum);
                double decim = 0.0;
                int lastspot;
                int increment = 1;

                while (binnum > 0)
                {
                    lastspot = binnum % 10;
                    decim = decim + lastspot * increment;
                    binnum = binnum / 10;
                    increment = increment * 2;
                }
                LabelBox.Text = decim.ToString();
            }

        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case ("0"):
                    ZeroButton.PerformClick();
                    break;
                case ("1"):
                    OneButton.PerformClick();
                    break;
                case ("2"):
                    TwoButton.PerformClick();
                    break;
                case ("3"):
                    ThreeButton.PerformClick();
                    break;
                case ("4"):
                    FourButton.PerformClick();
                    break;
                case ("5"):
                    FiveButton.PerformClick();
                    break;
                case ("6"):
                    SixButton.PerformClick();
                    break;
                case ("7"):
                    SevenButton.PerformClick();
                    break;
                case ("8"):
                    EightButton.PerformClick();
                    break;
                case ("9"):
                    NineButton.PerformClick();
                    break;
                case ("\r"):
                    EqualsButton.PerformClick();
                    break;
                case ("."):
                    PointButton.PerformClick();
                    break;
                case ("/"):
                    DivideButton.PerformClick();
                    break;
                case ("*"):
                    TimesButton.PerformClick();
                    break;
                case ("-"):
                    MinusButton.PerformClick();
                    break;
                case ("+"):
                    PlusButton.PerformClick();
                    break;
            }
        }
    }
}
