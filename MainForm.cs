using System.CodeDom;
using System.Reflection.Metadata.Ecma335;

namespace BetterWinFormsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        calcApp myCalculator = new calcApp();

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Int32.Parse(numberInput1.Text);
            int secondNumber = Int32.Parse(numberInput2.Text);
            string arithOperator = textOperator.Text;
            //int totalSum = firstNumber + secondNumber;
            //string sumAsString = totalSum.ToString();
            //resultContent.Text = sumAsString + arithOperator;
            string result = myCalculator.Calculate(firstNumber, secondNumber, arithOperator);
            resultContent.Text = result;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            numberInput1.Text = "";
            numberInput2.Text = "";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            textOperator.Text = "Addition";
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            textOperator.Text = "Subtraction";
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            textOperator.Text = "Division";
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            textOperator.Text = "Multiplication";
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Cris");
        }
    }
    public class calcApp()
    {
        public string Calculate(int num1, int num2, string calcOperator)
        {
            //int result = num1 + num2;
            //return result.ToString();
            double result = 0;
            switch (calcOperator) {
                case "Addition":
                    result = num1 + num2;
                    break;
                case "Subtraction":
                    result = num1 - num2;
                    break;
                case "Division":
                    result = num1 / num2;
                    break;
                case "Multiplication":
                    result = num1 * num2;
                    break;
                default:
                    return "Unknown Operation";
            }

            return result.ToString();
        }
    }
}
