using Calculator.Clases;
using Calculator.Interfaces;
using Calculator.Strategy;
using System;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Class to operate the calculator.
    /// </summary>
    public partial class Calculator : Form, ICalculator
    {
        /// <summary>
        /// First number to use for the calculation.
        /// </summary>
        private int iNumber1 { get; set; }

        /// <summary>
        /// Second number to use for the calculation.
        /// </summary>
        private int iNumber2 { get; set; }

        /// <summary>
        /// Result of the calculation.
        /// </summary>
        private double dResult { get; set; }

        /// <summary>
        /// Operator value.
        /// </summary>
        private string sOperator { get; set; }

        /// <summary>
        /// Constructor method.
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function is called whenever a button is pressed on the calculator.
        /// `number` can only be a char of '0' to '9'. No other values will be passed
        /// into the function.
        /// </summary>
        /// <param name="_sNumber">String value for number.</param>
        public void onNumberPressed(string _sNumber)
        {
            string sTextResult = this.txtResult.Text;

            if(string.IsNullOrWhiteSpace(sTextResult))
            {
                this.txtResult.Text = _sNumber;
            }
            else if(!string.IsNullOrWhiteSpace(sTextResult) && !this.labelOperation.Text.Contains("="))
            {
                sTextResult += _sNumber;
                this.txtResult.Text = sTextResult;
            }
            else
            {
                this.labelOperation.Text = string.Empty;
                this.txtResult.Text = _sNumber;
            }
        }

        /// <summary>
        /// This function is called whenever an operator is pressed on the calculator.
        /// `operator` can only be a char of '+', '-', '*', or '/'.
        /// </summary>
        /// <param name="_sOperator"></param>
        public void onOperatorPressed(string _sOperator)
        {
            sOperator = _sOperator;

            try
            {
                iNumber1 = Convert.ToInt32(this.txtResult.Text);
            }
            catch
            {
                MessageBox.Show("Only integer numbers!");
                this.labelOperation.Text = string.Empty;
                this.txtResult.Text = string.Empty;
                _sOperator = string.Empty;
            }

            this.labelOperation.Text = this.txtResult.Text + " " + _sOperator;
            this.txtResult.Text = string.Empty;            
        }

        /// <summary>
        /// This function is called after equals is pressed on the calculator. This
        /// function should return the value of the entire expression typed.
        /// Previously if someone has typed in 
        /// </summary>
        /// <returns>Return the result of the calculation.</returns>
        public double onEqualsPressed()
        {
            iNumber2 = Convert.ToInt32(this.txtResult.Text);
            this.labelOperation.Text = this.labelOperation.Text + " " + iNumber2.ToString() +" = ";


            StrategyCalculation strategyCalculation = new StrategyCalculation();
            ICalculation calculation = strategyCalculation.GetCalculationInstance(sOperator);

            dResult = calculation.Calculate2Numbers(iNumber1, iNumber2);

            sOperator = string.Empty;
            iNumber1 = 0;
            iNumber2 = 0;

            return dResult;
        }

        /// <summary>
        /// Method that is executed when the "7" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void Number7_Click(object sender, EventArgs e)
        {
            onNumberPressed("7");
        }

        /// <summary>
        /// Method that is executed when the "1" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number1_Click(object sender, EventArgs e)
        {
            onNumberPressed("1");
        }

        /// <summary>
        /// Method that is executed when the "2" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number2_Click(object sender, EventArgs e)
        {
            onNumberPressed("2");
        }

        /// <summary>
        /// Method that is executed when the "3" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number3_Click(object sender, EventArgs e)
        {
            onNumberPressed("3");
        }

        /// <summary>
        /// Method that is executed when the "4" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number4_Click(object sender, EventArgs e)
        {
            onNumberPressed("4");
        }

        /// <summary>
        /// Method that is executed when the "5" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number5_Click(object sender, EventArgs e)
        {
            onNumberPressed("5");
        }

        /// <summary>
        /// Method that is executed when the "6" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number6_Click(object sender, EventArgs e)
        {
            onNumberPressed("6");
        }

        /// <summary>
        /// Method that is executed when the "8" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number8_Click(object sender, EventArgs e)
        {
            onNumberPressed("8");
        }

        /// <summary>
        /// Method that is executed when the "9" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number9_Click(object sender, EventArgs e)
        {
            onNumberPressed("9");
        }

        /// <summary>
        /// Method that is executed when the "0" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void number0_Click(object sender, EventArgs e)
        {
            onNumberPressed("0");
        }

        /// <summary>
        /// Method that is executed when the "+" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void additionOp_Click(object sender, EventArgs e)
        {
            onOperatorPressed("+");
        }

        /// <summary>
        /// Method that is executed when the "-" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void substractionOp_Click(object sender, EventArgs e)
        {
            onOperatorPressed("-");
        }

        /// <summary>
        /// Method that is executed when the "*" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void multiplicationOp_Click(object sender, EventArgs e)
        {
            onOperatorPressed("*");
        }

        /// <summary>
        /// Method that is executed when the "/" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void divisionOp_Click(object sender, EventArgs e)
        {
            onOperatorPressed("/");
        }

        /// <summary>
        /// Method that is executed when the "=" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void equalsOp_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = onEqualsPressed().ToString();
        }

        /// <summary>
        /// Method that is executed when the "C" button is clicked.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event arguments.</param>
        private void clearOp_Click(object sender, EventArgs e)
        {
            this.labelOperation.Text = string.Empty;
            this.txtResult.Text = string.Empty;
            this.sOperator = string.Empty;
            this.iNumber1 = 0;
            this.iNumber2 = 0;
            this.dResult = 0;
        }
    }
}
