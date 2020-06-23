using CodeSignalSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace CodeSignalTest
{
    [TestClass]
    public class CodeSignalTests
    {
        #region The Journey Begins

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(0, 1000, 1000)]
        [DataRow(2, -39, -37)]
        [DataRow(99, 100, 199)]
        [DataRow(-100, 100, 0)]
        [DataRow(-1000, 1000, 0)]
        public void AddTest(int param1, int param2, int expected)
        {
            var result = Solution.Add(param1, param2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1905, 20)]
        [DataRow(1700, 17)]
        [DataRow(1988, 20)]
        [DataRow(2000, 20)]
        [DataRow(374, 4)]
        [DataRow(8, 1)]
        public void CenturyFromYearTest(int year, int expected)
        {
            var result = Solution.CenturyFromYear(year);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("aabaa", true)]
        [DataRow("abac", false)]
        [DataRow("a", true)]
        [DataRow("az", false)]
        [DataRow("abacaba", true)]
        [DataRow("z", true)]
        [DataRow("aaabaaaa", false)]
        [DataRow("zzzazzazz", false)]
        [DataRow("hlbeeykoqqqqokyeeblh", true)]
        [DataRow("hlbeeykoqqqokyeeblh", true)]

        public void CheckPalindromeTest(string input, bool expected)
        {
            var result = Solution.CheckPalindrome(input);

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Edge of the Ocean

        [TestMethod]
        [DataRow(new[] { 3, 6, -2, -5, 7, 3 }, 21)]
        [DataRow(new[] { -1, -2 }, 2)]
        [DataRow(new[] { 5, 1, 2, 3, 1, 4 }, 6)]
        [DataRow(new[] { 1, 2, 3, 0 }, 6)]
        [DataRow(new[] { 9, 5, 10, 2, 24, -1, -48 }, 50)]
        [DataRow(new[] { 5, 6, -4, 2, 3, 2, -23 }, 30)]
        [DataRow(new[] { 4, 1, 2, 3, 1, 5 }, 6)]
        [DataRow(new[] { -23, 4, -3, 8, -12 }, -12)]
        [DataRow(new[] { 1, 0, 1, 0, 1000 }, 0)]
        public void AdjacentElementsProductTest(int[] inputArray, int expected)
        {
            var result = Solution.AdjacentElementsProduct(inputArray);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 5)]
        [DataRow(3, 13)]
        [DataRow(1, 1)]
        [DataRow(7000, 97986001)]
        [DataRow(8000, 127984001)]
        [DataRow(9999, 199940005)]
        [DataRow(9998, 199900013)]
        [DataRow(8999, 161946005)]
        [DataRow(100, 19801)]
        public void ShapeArea(int n, int expected)
        {
            var result = Solution.ShapeArea(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new[] { 6, 2, 3, 8 }, 3)]
        [DataRow(new[] { 0, 3 }, 2)]
        [DataRow(new[] { 5, 4, 6 }, 0)]
        [DataRow(new[] { 6, 3 }, 2)]
        [DataRow(new[] { 1 }, 0)]
        public void MakeArrayConsecutive2(int[] inputArray, int expected)
        {
            var result = Solution.MakeArrayConsecutive2(inputArray);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new[] { 1, 3, 2, 1 }, false)]
        [DataRow(new[] { 1, 3, 2 }, true)]
        [DataRow(new[] { 1, 2, 1, 2 }, false)]
        [DataRow(new[] { 3, 6, 5, 8, 10, 20, 15 }, false)]
        [DataRow(new[] { 1, 1, 2, 3, 4, 4 }, false)]
        [DataRow(new[] { 1, 4, 10, 4, 2 }, false)]
        [DataRow(new[] { 10, 1, 2, 3, 4, 5 }, true)]
        [DataRow(new[] { 1, 1, 1, 2, 3 }, false)]
        [DataRow(new[] { 0, -2, 5, 6 }, true)]
        [DataRow(new[] { 1, 2, 3, 4, 5, 3, 5, 6 }, false)]
        [DataRow(new[] { 40, 50, 60, 10, 20, 30 }, false)]
        [DataRow(new[] { 1, 1 }, true)]
        [DataRow(new[] { 1, 2, 5, 3, 5 }, true)]
        [DataRow(new[] { 1, 2, 5, 5, 5 }, false)]
        [DataRow(new[] { 10, 1, 2, 3, 4, 5, 6, 1 }, false)]
        [DataRow(new[] { 1, 2, 3, 4, 3, 6 }, true)]
        [DataRow(new[] { 1, 2, 3, 4, 99, 5, 6 }, true)]
        [DataRow(new[] { 123, -17, -5, 1, 2, 3, 12, 43, 45 }, true)]
        [DataRow(new[] { 3, 5, 67, 98, 3 }, true)]
        public void AlmostIncreasingSequence(int[] sequence, bool expected)
        {
            var result = Solution.AlmostIncreasingSequence(sequence);

            Assert.AreEqual(expected, result);
        }

        #endregion
    }
}
