using CodeSignalSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodeSignalTest
{
    [TestClass]
    public class CodeSignalTests
    {
        /**************      Intro     **************/

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

        [TestMethod]
        [DataRow(new[] { 0, 1, 1, 2 }, new[] { 0, 5, 0, 0 }, new[] { 2, 0, 3, 3 }, 9)]
        [DataRow(new[] { 1, 1, 1, 0 }, new[] { 0, 5, 0, 1 }, new[] { 2, 1, 3, 10 }, 9)]
        [DataRow(new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 }, 18)]
        [DataRow(new[] { 1, 0, 3 }, new[] { 0, 2, 1 }, new[] { 1, 2, 0 }, 5)]
        [DataRow(new[] { 2 }, new[] { 5 }, new[] { 10 }, 17)]
        public void MatrixElementsSum(int[] a, int[] b, int[] c, int expected)
        {
            int[][] matrix = new int[][] { a, b, c };

            var result = Solution.MatrixElementsSum(matrix);

            Assert.AreEqual(expected, result);
        }

        #endregion

        #region Smooth Sailing

        [TestMethod]
        [DynamicData(nameof(TestDataMethod), DynamicDataSourceType.Method)]
        public void AllLongestStrings(string[] inputArray, string[] expected)
        {
            var result = Solution.AllLongestStrings(inputArray);

            CollectionAssert.AreEqual(expected, result);
        }

        static IEnumerable<object[]> TestDataMethod()
        {
            return new[] {
                new [] { new[] { "aba", "aa", "ad", "vcd", "aba" }, new[] { "aba", "vcd", "aba" } },
                new [] { new[] { "aa" }, new[] { "aa" } },
                new [] { new[] { "abc", "eeee", "abcd", "dcd" }, new[] { "eeee", "abcd" } },
                new [] { new[] {"a", "abc", "cbd", "zzzzzz", "a", "abcdef", "asasa", "aaaaaa" }, new[] { "zzzzzz", "abcdef", "aaaaaa" } },
                new [] { new[] { "enyky", "benyky", "yely", "varennyky" }, new[] { "varennyky" } },
                new [] { new[] {"abacaba", "abacab", "abac", "xxxxxx" }, new[] { "abacaba" } },
                new [] { new[] {"young", "yooooooung", "hot", "or", "not", "come", "on", "fire", "water", "watermelon"}, new[] { "yooooooung", "watermelon" } },
                new [] { new[] { "lbgwyqkry" }, new[] { "lbgwyqkry" } },
                new [] { new[] { "i" }, new[] { "i" } },
            };
        }

        [TestMethod]
        [DataRow("aabcc", "adcaa", 3)]
        [DataRow("zzzz", "zzzzzzz", 4)]
        [DataRow("abca", "xyzbac", 3)]
        [DataRow("a", "b", 0)]
        [DataRow("a", "aaa", 1)]
        public void CommonCharacterCount(string s1, string s2, int expected)
        {
            var result = Solution.CommonCharacterCount(s1, s2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        [DataRow(1230, true)]
        [DataRow(239017, false)]
        [DataRow(134008, true)]
        [DataRow(10, false)]
        [DataRow(11, true)]
        [DataRow(1010, true)]
        [DataRow(261534, false)]
        [DataRow(100000, false)]
        [DataRow(999999, true)]
        [DataRow(123321, true)]
        public void IsLucky(int n, bool expected)
        {
            var result = Solution.IsLucky(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new[] { -1, 150, 190, 170, -1, -1, 160, 180 }, new[] { -1, 150, 160, 170, -1, -1, 180, 190 })]
        [DataRow(new[] { -1, -1, -1, -1, -1 }, new[] { -1, -1, -1, -1, -1 })]
        [DataRow(new[] { -1 }, new[] { -1 })]
        [DataRow(new[] { 4, 2, 9, 11, 2, 16 }, new[] { 2, 2, 4, 9, 11, 16 })]
        [DataRow(new[] { 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1 }, new[] { 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2 })]
        [DataRow(new[] { 23, 54, -1, 43, 1, -1, -1, 77, -1, -1, -1, 3 }, new[] { 1, 3, -1, 23, 43, -1, -1, 54, -1, -1, -1, 77 })]

        public void SortByHeight(int[] a, int[] expected)
        {
            var result = Solution.SortByHeight(a);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("(bar)", "rab")]
        [DataRow("foo(bar)baz", "foorabbaz")]
        [DataRow("foo(bar)baz(blim)", "foorabbazmilb")]
        [DataRow("()", "")]
        [DataRow("(abc)d(efg)", "cbadgfe")]
        public void ReverseInParentheses(string inputString, string expected)
        {
            var result = Solution.ReverseInParentheses(inputString);

            Assert.AreEqual(expected, result);
        }


        #endregion

        /**************      The Core     **************/

        #region Core

        [TestMethod]
        [DataRow(16, 11, 5, 3, 96)]
        [DataRow(1, 1, 1, 1, 0)]
        [DataRow(13, 6, 8, 3, 18)]
        [DataRow(60, 100, 60, 1, 99)]
        [DataRow(1000, 1000, 1000, 1000, 0)]
        public void SeatsInTheater(int nCols, int nRows, int col, int row, int expected)
        {
            var result = Solution.SeatsInTheater(nCols, nRows, col, row);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 10, 9)]
        [DataRow(2, 7, 6)]
        [DataRow(10, 50, 50)]
        [DataRow(7, 100, 98)]
        [DataRow(7, 20, 14)]
        [DataRow(5, 13, 10)]
        [DataRow(8, 88, 88)]
        [DataRow(10, 100, 100)]
        [DataRow(2, 5, 4)]
        [DataRow(3, 5, 3)]
        [DataRow(9, 11, 9)]
        [DataRow(8, 15, 8)]
        [DataRow(9, 60, 54)]
        public void MaxMultiple(int divisor, int bound, int expected)
        {
            var result = Solution.MaxMultiple(divisor, bound);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(10, 2, 7)]
        [DataRow(10, 7, 2)]
        [DataRow(4, 1, 3)]
        [DataRow(6, 3, 0)]
        [DataRow(18, 6, 15)]
        [DataRow(12, 10, 4)]
        [DataRow(18, 5, 14)]
        public void CircleOfNumbers(int n, int firstNumber, int expected)
        {
            var result = Solution.CircleOfNumbers(n, firstNumber);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(240, 4)]
        [DataRow(808, 14)]
        [DataRow(1439, 19)]
        [DataRow(0, 0)]
        [DataRow(23, 5)]
        [DataRow(8, 8)]
        [DataRow(808, 14)]
        [DataRow(808, 14)]
        public void LateRide(int n, int expected)
        {
            var result = Solution.LateRide(n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 1, 2, 20, 14)]
        [DataRow(2, 2, 1, 2, 1)]
        [DataRow(10, 1, 2, 22, 11)]
        [DataRow(2, 2, 1, 24, 14)]
        [DataRow(1, 2, 1, 6, 3)]
        [DataRow(10, 10, 10, 8, 0)]
        public void PhoneCall(int min1, int min2_10, int min11, int s, int expected)
        {
            var result = Solution.PhoneCall(min1, min2_10, min11, s);

            Assert.AreEqual(expected, result);
        }




        #endregion
    }
}
