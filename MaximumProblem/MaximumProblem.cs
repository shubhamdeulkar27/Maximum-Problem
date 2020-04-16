using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum<T> where T: IComparable
    {
        /// <summary>
        /// FindMax Function returns maximum value which is of Generic type.
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <param name="param3"></param>
        /// <returns></returns>
        public T FindMax(T param1, T param2, T param3)
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
    }
}
 