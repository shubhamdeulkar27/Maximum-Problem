using NUnit.Framework;
using MaximumProblem;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace MaximumProblemTest
{
    /// <summary>
    /// MaximumProblemTest Class To Implemet the Test Cases.
    /// </summary>
    public class MaximumProblemTest
    {
        /// <summary>
        /// Test Case for Testing FindMaxInteger function.
        /// </summary>
        [Test]
        public void Test1()
        {
            int expected = 88;
            FindMaximum findMaximum = new FindMaximum(45, 45, 88);
            int result = findMaximum.FindMaxInteger();
            Assert.AreEqual(expected,result);
        }
    }
}