using Calculator.Interfaces;
using System;

namespace Calculator.Clases
{
    /// <summary>
    /// Class to calculate multiplication.
    /// </summary>
    public class MultiplicationCalculation : ICalculation
    {
        /// <summary>
        /// Perform a calculation between 2 numbers.
        /// </summary>
        /// <param name="_iNumber1">Number 1 value.</param>
        /// <param name="_iNumber2">Number 2 value.</param>
        /// <returns>Returns the calculation result.</returns>
        public double Calculate2Numbers(int _iNumber1, int _iNumber2)
        {
            double dResult = 0;
            double dNumber1 = Convert.ToDouble(_iNumber1);
            double dNumber2 = Convert.ToDouble(_iNumber2);

            dResult = dNumber1 * dNumber2;

            return dResult;
        }
    }
}
