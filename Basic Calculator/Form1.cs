using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Activates validation and calculation on the button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string firstNum = Convert.ToString(opOne.Text);
            string secondNum = Convert.ToString(opTwo.Text);
            string oppy = Convert.ToString(opBox.Text);


            if(isValidData(firstNum, oppy, secondNum) == true)
            {
                double operand1 = Convert.ToDouble(firstNum);
                double operand2 = Convert.ToDouble(secondNum);

                Calculate(oppy, operand1, operand2);
            }
            
        }
        /// <summary>
        /// Checks the data validation for each input
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="oppy"></param>
        /// <param name="secondNum"></param>
        /// <returns></returns>
        private bool isValidData(string firstNum, string oppy, string secondNum)
        {
            return
                IsPresent(firstNum) &&
                IsPresent(secondNum) &&
                IsPresent(oppy) &&

                IsDecimal(firstNum) &&
                IsDecimal(secondNum) &&

                ValidRange(firstNum) &&
                ValidRange(secondNum) &&

                IsOperator(oppy);
        }



        /// <summary>
        /// Method to calculate the result number
        /// </summary>
        /// <param name="oppy"> Opperator </param>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        private double Calculate(string oppy, double operand1, double operand2)
        {
            double resultNum = 0;

            if (oppy == "/")
            {
                resultNum = operand1 / operand2;
            }
            else if (oppy == "*")
            {
                resultNum = operand1 * operand2;
            }
            else if (oppy == "-")
            {
                resultNum = operand1 - operand2;
            }
            else if (oppy == "+")
            {
                resultNum = operand1 + operand2;
            }

            //double resultNum = firstNum + oppy + secondNum;
            resultNum = Math.Round(resultNum, 4);
            result.Text = resultNum.ToString();
            return resultNum;
        }
        
        /// <summary>
        /// Checks if the userInput is within a valid range of numbers
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private bool ValidRange(string userInput)
        {
            double userNum = Convert.ToDouble(userInput);
            if(userNum > 0 && userNum < 1000000)
            {
                return true;
            }
            return false;
        }

        //private bool IsNumber(string userInput)
        //{
        //    try
        //    {
        //        Convert.ToDouble(userInput); 
        //        return true;
        //    }
        //    catch (FormatException) 
        //    {
        //        return false;
        //    }
        //}

        /// <summary>
        /// Checks for specific operator notations like division, multiplication, subtraction, and addition
        /// </summary>
        /// <param name="oppy"></param>
        /// <returns></returns>
        private bool IsOperator(string oppy)
        {
            if (oppy == "/")
            {
                return true;
            }
            else if (oppy == "*")
            {
                return true;
            }
            else if (oppy == "-")
            {
                return true;
            }
            else if (oppy == "+")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Operator must be / (Divide) * (Multiplication - (subtraction) or + (Addition)");
                return false;
            }
        }
        /// <summary>
        /// Checks to make sure that there is data present in the fields
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private bool IsPresent(string userInput)
        {
            if (userInput == "" || userInput == null)
            {
                MessageBox.Show("Please make sure to enter data");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if the userInput can be a decimal
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public bool IsDecimal(string userInput)
        {
            double numInput;

            if (!double.TryParse(userInput, out numInput))
            {
                MessageBox.Show("Please enter a valid number");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Exits the application when clicking the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Clears the result box if any text is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opOne_TextChanged(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
