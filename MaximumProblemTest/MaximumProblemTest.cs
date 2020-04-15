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
            FindMaximum findMaximum = new FindMaximum();
            int result = findMaximum.FindMaxInteger(45, 45, 88);
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMaxFloat function.
        /// </summary>
        [Test]
        public void Test2()
        {
            float expected = 99.99f;
            FindMaximum findMaximum = new FindMaximum();
            float result = findMaximum.FindMaxFloat(24.1456f,1.225f,99.99f);
            Assert.AreEqual(expected,result);
        }
    }
}