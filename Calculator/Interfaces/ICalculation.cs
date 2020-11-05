namespace Calculator.Interfaces
{
    /// <summary>
    /// Interface for Calculation.
    /// </summary>
    public interface ICalculation
    {
        /// <summary>
        /// Perform a calculation between 2 numbers.
        /// </summary>
        /// <param name="_iNumber1">Number 1 value.</param>
        /// <param name="_iNumber2">Number 2 value.</param>
        /// <returns>Returns the calculation result.</returns>
        double Calculate2Numbers(int _iNumber1, int _iNumber2);
    }
}