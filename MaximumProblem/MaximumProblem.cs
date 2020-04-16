using System;

namespace MaximumProblem
{
    /// <summary>
    /// FindMaximum Class Has 3 Variables from which it finds Maximum.
    /// </summary>
    public class FindMaximum<T> where T: IComparable
    {
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
 