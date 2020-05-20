using System;
using System.Windows.Forms;

namespace Day_24
{
    public partial class Main : Form
    {
        private double A = 0;
        private double B = 0;
        private double C = 0;
        private double X = 0;
        private double inputedNumber = 0;
        private string mathOperation;
        public Main()
        {
            InitializeComponent();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            A = 0;
            B = 0;
            C = 0;
            X = 0;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            string content = resultsTextBox.Text;
            if (content.Length < 1)
            {
                textBoxTip.ToolTipIcon = ToolTipIcon.Info;
                textBoxTip.Show("Text area is empty, nothing to remove!", resultsTextBox, 1000);
                return;
            }
            resultsTextBox.Text = content.Remove(content.Length - 1);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            A = inputedNumber;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
            mathOperation = "div";
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            A = inputedNumber;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
            mathOperation = "multi";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            A = inputedNumber;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
            mathOperation = "minus";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            A = inputedNumber;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
            mathOperation = "plus";
        }

        private void oneDivXBtn_Click(object sender, EventArgs e)
        {
            try
            {
                A = 1;
                B = inputedNumber;
                C = MathManager.Division(A, B);
                inputedNumber = C;
                resultsTextBox.Text = C.ToString().Replace(',', '.');
            }
            catch (DivideByZeroException ex)
            {
                textBoxTip.ToolTipIcon = ToolTipIcon.Error;
                textBoxTip.Show(ex.Message, resultsTextBox, 1000);
                return;
            }
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            A = inputedNumber;
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
            mathOperation = "mod";
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            X = inputedNumber;
            C = MathManager.Sqrt(X);
            inputedNumber = C;
            resultsTextBox.Text = C.ToString().Replace(',', '.');
        }

        private void mPlusBtn_Click(object sender, EventArgs e)
        {
            MemoryManager.MemoryPlus(inputedNumber);
        }

        private void msBtn_Click(object sender, EventArgs e)
        {
            MemoryManager.MemoryStore(inputedNumber);
        }

        private void mrBtn_Click(object sender, EventArgs e)
        {
            inputedNumber = MemoryManager.MemoryRecall();
            resultsTextBox.Text = inputedNumber.ToString().Replace(',', '.');
        }

        private void mcBtn_Click(object sender, EventArgs e)
        {
            MemoryManager.MemoryClear();
        }

        private void clearCurrentBtn_Click(object sender, EventArgs e)
        {
            inputedNumber = 0;
            resultsTextBox.Text = string.Empty;
        }

        private void posNegBtn_Click(object sender, EventArgs e)
        {
            inputedNumber *= (-1);
            resultsTextBox.Text = inputedNumber.ToString();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
                return;

            resultsTextBox.Text += "0";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "1";
                return;
            }
            resultsTextBox.Text += "1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "2";
                return;
            }
            resultsTextBox.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "3";
                return;
            }
            resultsTextBox.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "4";
                return;
            }
            resultsTextBox.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "5";
                return;
            }
            resultsTextBox.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "6";
                return;
            }
            resultsTextBox.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "7";
                return;
            }
            resultsTextBox.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "8";
                return;
            }
            resultsTextBox.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Equals("0"))
            {
                resultsTextBox.Text = "9";
                return;
            }
            resultsTextBox.Text += "9";
        }

        private void resultsTextBox_TextChanged(object sender, EventArgs e)
        {
            if(resultsTextBox.Text.Length > 0)
                inputedNumber = double.Parse(resultsTextBox.Text.ToString().Replace('.', ','));
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            if (resultsTextBox.Text.Contains(".") || resultsTextBox.Text.Length == 0)
                return;

            resultsTextBox.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inputedNumber.ToString());
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch(mathOperation)
            {
                case "plus":
                    B = inputedNumber;
                    C = MathManager.Plus(A, B);
                    inputedNumber = C;
                    resultsTextBox.Text = C.ToString().Replace(',', '.');
                    break;
                case "minus":
                    B = inputedNumber;
                    C = MathManager.Minus(A, B);
                    inputedNumber = C;
                    resultsTextBox.Text = C.ToString().Replace(',', '.');
                    break;
                case "multi":
                    B = inputedNumber;
                    C = MathManager.Multiplication(A, B);
                    inputedNumber = C;
                    resultsTextBox.Text = C.ToString().Replace(',', '.');
                    break;
                case "mod":
                    B = inputedNumber;
                    C = MathManager.Mod(A, B);
                    inputedNumber = C;
                    resultsTextBox.Text = C.ToString().Replace(',', '.');
                    break;
                case "div":
                    try
                    {
                        B = inputedNumber;
                        C = MathManager.Division(A, B);
                        inputedNumber = C;
                        resultsTextBox.Text = C.ToString().Replace(',', '.');
                    }
                    catch (DivideByZeroException ex)
                    {
                        textBoxTip.ToolTipIcon = ToolTipIcon.Error;
                        textBoxTip.Show(ex.Message, resultsTextBox, 1000);
                        return;
                    }
                    break;
            }
        }
    }
}
