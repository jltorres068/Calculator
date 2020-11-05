using Calculator.Clases;
using Calculator.Interfaces;

namespace Calculator.Strategy
{
    /// <summary>
    /// Class StrategyCalculation.
    /// </summary>
    public class StrategyCalculation
    {
        /// <summary>
        /// Method to get the correct instance based on the parameter.
        /// </summary>
        /// <param name="_sOperator">String with the operator value.</param>
        /// <returns>Returns an instance of ICalculation.</returns>
        public ICalculation GetCalculationInstance(string _sOperator)
        {
            ICalculation calculationInstance = null;

            switch (_sOperator)
            {
                case "+":
                    calculationInstance = new AdditionCalculation();
                    break;

                case "-":
                    calculationInstance = new SubstractionCalculation();
                    break;

                case "*":
                    calculationInstance = new MultiplicationCalculation();
                    break;

                case "/":
                    calculationInstance = new DivisionCalculation();
                    break;
            }

            return calculationInstance;
        }
    }
}