using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum<T> where T : IComparable
    {
        //Varibales.
        private T[] parameterArray;
        
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
        public FindMaximum(params T[] paramArray)
        {
            this.parameterArray = paramArray;
        }

        /// <summary>
        /// FindMax function which takes multiple parameter and sort it and returns maximum value.
        /// </summary>
        /// <param name="paramAr"></param>
        /// <returns></returns>
        public static T FindMax(params T[] paramAr)
        {
            Array.Sort<T>(paramAr);
            int arraySize = paramAr.Length;
            T result = paramAr[arraySize - 1];
            return result;
        }

        /// <summary>
        /// FindMax Funtion Internally Calls FindMax Static function.
        /// </summary>
        /// <returns></returns>
        public T FindMax()
        {
            T result=FindMaximum<T>.FindMax(parameterArray);
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
 