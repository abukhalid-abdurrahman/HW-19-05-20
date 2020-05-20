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
            try
            {
                C = MathManager.Division(A, B);
            }
            catch (DivideByZeroException ex)
            {
                textBoxTip.ToolTipIcon = ToolTipIcon.Error;
                textBoxTip.Show(ex.Message, resultsTextBox, 1000);
                return;
            }
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            C = MathManager.Multiplication(A, B);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            C = MathManager.Minus(A, B);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            C = MathManager.Plus(A, B);
        }

        private void oneDivXBtn_Click(object sender, EventArgs e)
        {
            try
            {
                A = 1;
                C = MathManager.Division(A, B);
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
            C = MathManager.Plus(A, B);
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            C = MathManager.Sqrt(X);
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
            C = MemoryManager.MemoryRecall();
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
    }
}
