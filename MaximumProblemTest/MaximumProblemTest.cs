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
            int result = FindMaximum<int>.FindMax(45, 45, 88);
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMaxFloat function.
        /// </summary>
        [Test]
        public void TestFloat()
        {
            float expected = 99.99f;
            float result = FindMaximum<float>.FindMax(24.1456f,1.225f,99.99f);
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMaxString functon.
        /// </summary>
        [Test]
        public void TestString()
        {
            string expected = "PQR";
            string result = FindMaximum<string>.FindMax("ABC", "DEF", "PQR");
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing FindMax Function.
        /// </summary>
        [Test]
        public void TestFindMaxFunction()
        {
            int expected = 99;
            FindMaximum<int> findMaximum = new FindMaximum<int>(12,56,99);
            int result = findMaximum.FindMax();
            Assert.AreEqual(expected,result);
        }

        /// <summary>
        /// Test Case For Testing Multiple Parameter feature.
        /// </summary>
        [Test]
        public void TestMultipleParameter()
        {
            string expected = "ZZZ";
            FindMaximum<string> findMaximum = new FindMaximum<string>("ABC","SED","RRR","XYZ","ZZZ");
            string result = findMaximum.FindMax();
            Assert.AreEqual(expected, result);
        }
    }
}