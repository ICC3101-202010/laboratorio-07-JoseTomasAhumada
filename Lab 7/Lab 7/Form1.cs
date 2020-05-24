using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Calculator : Form
    {
        float firstNumber;
        float secondNumber;
        string operation;
        string answer;
        public Calculator()
        {
            InitializeComponent();
        }
        Addition add = new Addition();
        Substraction sub = new Substraction();
        Multiplication mul = new Multiplication();
        Division div = new Division();
        private void Calculator_Load(object sender, EventArgs e)
        {
            panel1.SendToBack();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.Text == "MATH ERROR" || ScreentextBox.Text == "SYNTAX ERROR")
            {
                ScreentextBox.Text = "";
            }
            ScreentextBox.Text = ScreentextBox.Text + "9";
        }
        private void Dotbutton_Click(object sender, EventArgs e)
        {
            ScreentextBox.Text = ScreentextBox.Text + ",";
        }

        private void Aditionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "+";
                firstNumber = float.Parse(ScreentextBox.Text);
                ScreentextBox.Clear();
            }
            catch
            {
                ScreentextBox.Text = "SYNTAX ERROR";
            }
        }

        private void Substractionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "-";
                firstNumber = float.Parse(ScreentextBox.Text);
                ScreentextBox.Clear();
            }
            catch
            {
                ScreentextBox.Text = "SYNTAX ERROR";
            }
        }

        private void Multiplicationbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "*";
                firstNumber = float.Parse(ScreentextBox.Text);
                ScreentextBox.Clear();
            }
            catch
            {
                ScreentextBox.Text = "SYNTAX ERROR";
            }
        }

        private void Divisionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operation = ":";
                firstNumber = float.Parse(ScreentextBox.Text);
                ScreentextBox.Clear();
            }
            catch
            {
                ScreentextBox.Text = "SYNTAX ERROR";
            }
        }

        private void Equalbutton_Click(object sender, EventArgs e)
        {
            try
            {
                secondNumber = float.Parse(ScreentextBox.Text);
                double Add;
                double Sub;
                double Mul;
                double Div;
                if (operation == "+")
                {
                    Add = add.Add(firstNumber, secondNumber);
                    ScreentextBox.Text = Add.ToString();
                    answer = Add.ToString();
                    HistoryTextBox.Text += (firstNumber + operation + secondNumber + "=" + answer + "\n");
                }
                if (operation == "-")
                {
                    Sub = sub.Substract(firstNumber, secondNumber);
                    ScreentextBox.Text = Sub.ToString();
                    answer = Sub.ToString();
                    HistoryTextBox.Text += (firstNumber + operation + secondNumber + "=" + answer + "\n");
                }
                if (operation == "*")
                {
                    Mul = mul.Multiply(firstNumber, secondNumber);
                    ScreentextBox.Text = Mul.ToString();
                    answer = Mul.ToString();
                    HistoryTextBox.Text += (firstNumber + operation + secondNumber + "=" + answer + "\n");
                }
                if (operation == ":")
                {
                    if (secondNumber == 0)
                    {
                        ScreentextBox.Text = "MATH ERROR";
                    }
                    else
                    {
                        Div = div.Divide(firstNumber, secondNumber);
                        ScreentextBox.Text = Div.ToString();
                        answer = Div.ToString();
                        HistoryTextBox.Text += (firstNumber + operation + secondNumber + "=" + answer + "\n");
                    }
                }
            }
            catch
            {
                ScreentextBox.Text = "SYNTAX ERROR";
            }
        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (ScreentextBox.TextLength == 1)
            {
                ScreentextBox.Text = "";
            }
            if (ScreentextBox.TextLength == 0)
            {
                ScreentextBox.Text = "";
            }
            else
            {
                ScreentextBox.Text = ScreentextBox.Text.Substring(0, ScreentextBox.TextLength - 1);
            }
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {
            ScreentextBox.Clear();
        }

        private void Answerbutton_Click(object sender, EventArgs e)
        {
            ScreentextBox.Text = answer;
        }
        private void Historybutton_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            HistoryTextBox.BackColor = Color.Black;
        }

        private void HistoryTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void History2button_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            HistoryTextBox.BackColor = Color.White;
        }

        private void DeleteHistorybutton_Click(object sender, EventArgs e)
        {
            HistoryTextBox.Text = "";
        }
    }
}
