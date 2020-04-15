using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum
    {
        //Variables
        private int number1;
        private int number2;
        private int number3;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public FindMaximum() { }

        /// <summary>
        /// Parameterised Constructor which Takes 3 Paramter to set fields.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        public FindMaximum(int number1, int number2, int number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;

        }

        /// <summary>
        /// Function to find the Maximum Ineteger Value.
        /// </summary>
        /// <returns></returns>
        public int FindMaxInteger()
        {
            if (number1 > number2 && number1 > number3)
                return number1;
            else if (number2 > number1 && number2 > number3)
                return number2;
            else
                return number3;
        }
    }
}
