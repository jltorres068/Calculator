namespace Calculator.Interfaces
{
    /// <summary>
    /// Interface ICalculator with the actions for the calculator.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// This function is called whenever a button is pressed on the calculator.
        /// `number` can only be a char of '0' to '9'. No other values will be passed
        /// into the function.
        /// </summary>
        /// <param name="_sNumber">String value for number.</param>
        void onNumberPressed(string _sNumber);

        /// <summary>
        /// This function is called whenever an operator is pressed on the calculator.
        /// `operator` can only be a char of '+', '-', '*', or '/'.
        /// </summary>
        /// <param name="_sOperator"></param>
        void onOperatorPressed(string _sOperator);

        /// <summary>
        /// This function is called after equals is pressed on the calculator. This
        /// function should return the value of the entire expression typed.
        /// Previously if someone has typed in 
        /// </summary>
        /// <returns>Return the result of the calculation.</returns>
        double onEqualsPressed();
    }
}