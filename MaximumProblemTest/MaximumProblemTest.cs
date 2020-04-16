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
        public void TestInteger()
        {
            int expected = 88;
            FindMaximum<int> findMaximum = new FindMaximum<int>();
            int result = findMaximum.FindMax(45, 45, 88);
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMaxFloat function.
        /// </summary>
        [Test]
        public void TestFloat()
        {
            float expected = 99.99f;
            FindMaximum<float> findMaximum = new FindMaximum<float>();
            float result = findMaximum.FindMax(24.1456f,1.225f,99.99f);
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMaxString functon.
        /// </summary>
        [Test]
        public void TestString()
        {
            string expected = "PQR";
            FindMaximum<string> findMaximum = new FindMaximum<string>();
            string result = findMaximum.FindMax("ABC", "DEF", "PQR");
            Assert.AreEqual(expected,result);
        }
    }
}