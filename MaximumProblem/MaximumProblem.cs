using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum
    {
        /// <summary>
        /// Function to find the Maximum Ineteger Value.
        /// </summary>
        /// <returns></returns>
        public int FindMaxInteger(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
                return number1;
            else if (number2 > number1 && number2 > number3)
                return number2;
            else
                return number3;
        }

        /// <summary>
        /// Fnction to find Maximum floating point value.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="number3"></param>
        /// <returns></returns>
        public float FindMaxFloat(float number1, float number2, float number3)
        {
            if (number1 > number2 && number1 > number3)
                return number1;
            else if (number2 > number1 && number2 > number3)
                return number2;
            else
                return number3;
        }

        /// <summary>
        /// FindMaxString function returns maximum string from the input.
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <param name="string3"></param>
        /// <returns></returns>
        public string FindMaxString(string string1, string string2, string string3)
        {
            if (string.Compare(string1, string2) == 1 && string.Compare(string1, string3) == 1)
            {
                return string1;
            }
            else if (string.Compare(string2, string1) == 1 && string.Compare(string2, string3) == 1)
            {
                return string2;
            }
            else if (string.Compare(string3, string1) == 1 && string.Compare(string3, string2) == 1)
            {
                return string3;
            }
            else
                return "0";
        }
    }
}
 