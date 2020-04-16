using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum<T> where T : IComparable
    {
        //Varibales.
        private T param1;
        private T param2;
        private T param3;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public FindMaximum() { }

        /// <summary>
        /// Paramterised Constructor.
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        public FindMaximum(T param1, T param2, T param3)
        {
            this.param1 = param1;
            this.param2 = param2;
            this.param3 = param3;
        }


        /// <summary>
        /// FindMax Function returns maximum value which is of Generic type.
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <returns></returns>
        public static T FindMax(T param1, T param2, T param3)
        {
            if (param1.CompareTo(param2) > 0)
            {
                return (param1.CompareTo(param3) > 0) ? param1 : param3;
            }
            else
            {
                return (param2.CompareTo(param3) > 0) ? param2 : param3;
            }
        }

        /// <summary>
        /// FindMax Funtion Internally Calls FindMax Static function.
        /// </summary>
        /// <returns></returns>
        public T FindMax()
        {
            T result=FindMaximum<T>.FindMax(param1, param2, param3);
            FindMaximum<T>.PrintMax(result);
            return result;
        }

        /// <summary>
        /// PrintMax Method which Takes result of Generic type and prints it on std out.
        /// </summary>
        /// <param name="result"></param>
        public static void PrintMax(T result)
        {
            Console.WriteLine(result);
        }
    }
}
 