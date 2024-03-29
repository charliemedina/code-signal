using CodeSignalSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            var actual = Solution.Add(param1, param2);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.CenturyFromYear(year);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.CheckPalindrome(input);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.AdjacentElementsProduct(inputArray);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.ShapeArea(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 6, 2, 3, 8 }, 3)]
        [DataRow(new[] { 0, 3 }, 2)]
        [DataRow(new[] { 5, 4, 6 }, 0)]
        [DataRow(new[] { 6, 3 }, 2)]
        [DataRow(new[] { 1 }, 0)]
        public void MakeArrayConsecutive2(int[] inputArray, int expected)
        {
            var actual = Solution.MakeArrayConsecutive2(inputArray);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.AlmostIncreasingSequence(sequence);

            Assert.AreEqual(expected, actual);
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

            var actual = Solution.MatrixElementsSum(matrix);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Smooth Sailing

        [TestMethod]
        [DynamicData(nameof(AllLongestStringsDynamic), DynamicDataSourceType.Method)]
        public void AllLongestStrings(string[] inputArray, string[] expected)
        {
            var actual = Solution.AllLongestStrings(inputArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        static IEnumerable<object[]> AllLongestStringsDynamic()
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
            var actual = Solution.CommonCharacterCount(s1, s2);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.IsLucky(n);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.SortByHeight(a);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("(bar)", "rab")]
        [DataRow("foo(bar)baz", "foorabbaz")]
        [DataRow("foo(bar)baz(blim)", "foorabbazmilb")]
        [DataRow("()", "")]
        [DataRow("(abc)d(efg)", "cbadgfe")]
        public void ReverseInParentheses(string inputString, string expected)
        {
            var actual = Solution.ReverseInParentheses(inputString);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Exploring the Waters

        [TestMethod]
        [DataRow(new[] { 50, 60, 60, 45, 70 }, new[] { 180, 105 })]
        [DataRow(new[] { 100, 50 }, new[] { 100, 50 })]
        [DataRow(new[] { 80 }, new[] { 80, 0 })]
        [DataRow(new[] { 100, 50, 50, 100 }, new[] { 150, 150 })]
        [DataRow(new[] { 100, 51, 50, 100 }, new[] { 150, 151 })]
        public void AlternatingSums(int[] a, int[] expected)
        {
            var actual = Solution.AlternatingSums(a);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new string[] { "aa", "**", "zz" })]
        public void AddBorder(string[] picture)
        {
            var actual = Solution.AddBorder(picture);

            CollectionAssert.AreEqual(new string[] { "****", "*aa*", "****", "*zz*", "****" }, actual);
        }

        [TestMethod]
        [DynamicData(nameof(AllLongestStringsDynamic), DynamicDataSourceType.Method)]
        public void AddBorder(string[] inputArray, string[] expected)
        {
            var actual = Solution.AllLongestStrings(inputArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        static IEnumerable<object[]> AddBorderDynamic()
        {
            return new[] {
                new [] { new[] { "aa", "**", "zz"  }, new[] { "****", "*aa*", "****", "*zz*", "****" } },
                new [] { new[] { "a" }, new[] { "***", "*a*", "***" } },
                new [] { new[] { "aa", "**", "zz" }, new[] { "****", "*aa*", "****", "*zz*", "****" } },
                new [] { new[] { "abcde", "fghij", "klmno", "pqrst", "uvwxy" }, new[] { "*******", "*abcde*", "*fghij*", "*klmno*", "*pqrst*", "*uvwxy*", "*******" } },
                new [] { new[] { "wzy**" }, new[] { "*******", "*wzy***", "*******" } }
            };
        }

        [TestMethod]
        [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, true)]
        [DataRow(new[] { 1, 2, 3 }, new[] { 2, 1, 3 }, true)]
        [DataRow(new[] { 1, 2, 2 }, new[] { 2, 1, 1 }, false)]
        [DataRow(new[] { 1, 1, 4 }, new[] { 1, 2, 3 }, false)]
        [DataRow(new[] { 1, 2, 3 }, new[] { 1, 10, 2 }, false)]
        [DataRow(new[] { 2, 3, 1 }, new[] { 1, 3, 2 }, true)]
        [DataRow(new[] { 2, 3, 9 }, new[] { 10, 3, 2 }, false)]
        [DataRow(new[] { 4, 6, 3 }, new[] { 3, 4, 6 }, false)]
        [DataRow(new[] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 }, new[] { 832, 998, 148, 570, 533, 561, 455, 147, 894, 279 }, true)]
        [DataRow(new[] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 }, new[] { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 }, false)]
        public void AreSimilar(int[] a, int[] b, bool expected)
        {
            var actual = Solution.AreSimilar(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 1, 1, 1 }, 3)]
        [DataRow(new[] { -1000, 0, -2, 0 }, 5)]
        [DataRow(new[] { 2, 1, 10, 1 }, 12)]
        [DataRow(new[] { 2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15 }, 13)]
        [DataRow(new[] { 3122, -645, 2616, 13213, -8069 }, 25559)]
        [DataRow(new[] { -787, -773, -93, 867, -28, 118, 372, 255, 355, 598, -179, -752, 794, 961, -84, 296, -714, 14, 666,
            -265, -905, 942, -691, -379, -698, -650, 637, 523, 709, -674, 574, -239, 805, -434, 597, -677, 664, 384, 726, -389,
            -387, 772, -603, 685, 249, 446, -631, 454, 983, 867, -158, 932, -440, 891, -12, 400, -916, 503, 185, -802, -255, 207,
            -952, -506, -689, 425, 747, -907, -30, 102, 553, 981, -664, 75, -957, -42, 99, -750, -277, 686, -884, -972, 470, 32,
            439, 163, 887, 895, -555, -654, 793, 333, 143, 73, 181, -512, -915, -68, 542, 799 }, 89510)]
        [DataRow(new[] { -28943, -29728, -24726, -15090, -2555, -9551, -11025, 36442, -23240, -46093, 48516, 44580, -21573, 39172, -38017,
            -19354, -13460, 38212, -35646, -22288, 36832, -33115, 39055, -15935, -19300, -10419, -18548, 21742, -32032, 27988, -45323,
            27454, -5683, -14209, -4168, 51188, 45552, 9899, 49241, -25939, -8344, -25788, 6808, 6931, 6145, -30802, -518, -42362 }, 2020705)]
        [DataRow(new[] { 9796, 1283, -2825, 3870, -6727, -8616, -10191, -7727, 7074, 1580, -4583, 162, 2980, -3861, 9452, 8145, 1222, -1125, 5142,
            -5657, -974, -986, -9627, 5244, 8866, 3336, -9946, -5271, 10582, 3013, 8030, 4471, -3420, 9496, -3533, -8030, 10007, 2549, -8195, 7119,
            302, -5322, -3537, 209, -8134, -9176, 6336, -1771, 9851, 3644, 9629, -2603, 3988, 10579, 2221, 1101, 1465, 5002, -6203, -8864, 596, 6005,
            4554, 8526, 2178, -5447, -232, -9734, 7402, -3984, -7161, -2139, -3181, 10445, 4535, 6926, 7156 }, 737073)]
        [DataRow(new[] { -24875, -6401, 58256, 44456, 2244, -25333, -42389, -5975, 7650, -46343, -62011, -55366, 7802, -37699, 15461, 13309, -58664,
            54557, 56324, -34397, -33024, -21934, -18861, -23196, 56542, -63986, 59833, -45610, -16948, 399, -7405, 54701, -57348, -32627, 65534, 615 }, 2199614)]
        public void ArrayChange(int[] inputArray, int expected)
        {
            var actual = Solution.ArrayChange(inputArray);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("aabb", true)]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc", false)]
        [DataRow("abbcabb", true)]
        [DataRow("zyyzzzzz", true)]
        [DataRow("z", true)]
        [DataRow("zaa", true)]
        [DataRow("abca", false)]
        [DataRow("abcad", false)]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbccccaaaaaaaaaaaaa", false)]
        [DataRow("abdhuierf", false)]
        public void PalindromeRearranging(string inputString, bool expected)
        {
            var actual = Solution.PalindromeRearranging(inputString);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Island of Knowledge

        [TestMethod]
        [DataRow(10, 15, 10, 15, true)]
        [DataRow(15, 10, 15, 10, true)]
        [DataRow(10, 15, 15, 9, false)]
        [DataRow(5, 5, 10, 10, false)]
        public void AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight, bool expected)
        {
            var actual = Solution.AreEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 2, 4, 1, 0 }, 3)]
        [DataRow(new[] { 1, 1, 1, 1 }, 0)]
        [DataRow(new[] { -1, 4, 10, 3, -2 }, 7)]
        [DataRow(new[] { 10, 11, 13 }, 2)]
        [DataRow(new[] { -2, -2, -2, -2, -2 }, 0)]
        [DataRow(new[] { -1, 1, -3, -4 }, 4)]
        [DataRow(new[] { -14, 15, -15 }, 30)]
        public void ArrayMaximalAdjacentDifference(int[] inputArray, int expected)
        {
            var actual = Solution.ArrayMaximalAdjacentDifference(inputArray);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("172.16.254.1", true)]
        [DataRow("172.316.254.1", false)]
        [DataRow(".254.255.0", false)]
        [DataRow("1.1.1.1a", false)]
        [DataRow("1", false)]
        [DataRow("0.254.255.0", true)]
        [DataRow("1.23.256.255.", false)]
        [DataRow("1.23.256..", false)]
        [DataRow("0..1.0", false)]
        [DataRow("64.233.161.00", false)]
        [DataRow("01.233.161.131", false)]
        [DataRow("35..36.9.9.0", false)]
        [DataRow("1.1.1.1.1", false)]
        [DataRow("1.256.1.1", false)]
        [DataRow("a0.1.1.1", false)]
        [DataRow("0.1.1.256", false)]
        [DataRow("129380129831213981.255.255.255", false)]
        [DataRow("255.255.255.255abcdekjhf", false)]
        [DataRow("7283728", false)]
        [DataRow("0..1.0.0", false)]
        public void IsIPv4Address(string inputArray, bool expected)
        {
            var actual = Solution.IsIPv4Address(inputArray);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 5, 3, 6, 7, 9 }, 4)]
        [DataRow(new[] { 2, 3 }, 4)]
        [DataRow(new[] { 1, 4, 10, 6, 2 }, 7)]
        [DataRow(new[] { 1000, 999 }, 6)]
        [DataRow(new[] { 19, 32, 11, 23 }, 3)]
        [DataRow(new[] { 5, 8, 9, 13, 14 }, 6)]
        public void AvoidObstacles(int[] inputArray, int expected)
        {
            var actual = Solution.AvoidObstacles(inputArray);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DynamicData(nameof(BoxBlurJaggedArraysDynamic), DynamicDataSourceType.Method)]
        public void BoxBlur(int[][] inputArray, int[][] expected)
        {
            var actual = Solution.BoxBlur(inputArray);

            for (int i = 0; i < actual.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
        static IEnumerable<object[]> BoxBlurJaggedArraysDynamic()
        {
            return new[] {
               new[] { new[] { new[] { 1, 1, 1 }, new[] { 1, 7, 1 }, new[] { 1, 1, 1 } }, new[] { new[] { 1 } } },
               new[] { new[] { new[] { 0, 18, 9 }, new[] { 27, 9, 0 }, new[] { 81, 63, 45 } }, new[] { new[] { 28 } } },
               new[] { new[] { new[] { 36, 0, 18, 9 }, new[] { 27, 54, 9, 0 }, new[] { 81, 63, 72, 45 } }, new[] { new[] { 40, 30 } } },
               new[] { new[] { new[] { 7, 4, 0, 1 }, new[] { 5, 6, 2, 2 }, new[] { 6, 10, 7, 8 }, new[] { 1, 4, 2, 0 } }, new[] { new[] { 5, 4 }, new[] { 4, 4 } } },
               new[] { new[] { new[] { 36, 0, 18, 9, 9, 45, 27 }, new[] { 27,0,54,9,0,63,90 }, new[] { 81, 63, 72, 45, 18, 27, 0 }, new[] { 0, 0, 9, 81, 27, 18, 45 },
                    new[] { 45, 45, 27, 27, 90, 81, 72 }, new[] { 45, 18, 9, 0, 9, 18, 45 }, new[] { 27, 81, 36, 63, 63, 72, 81 } },
                    new[] { new[] { 39, 30, 26, 25, 31 }, new[] { 34, 37, 35, 32, 32 }, new[] { 38, 41, 44, 46, 42 }, new[] { 22, 24, 31, 39, 45 }, new[] { 37, 34, 36, 47, 59 } } },
            };
        }

        [TestMethod]
        [DynamicData(nameof(MinesweeperJaggedArraysDynamic), DynamicDataSourceType.Method)]
        public void Minesweeper(bool[][] matrix, int[][] expected)
        {
            var actual = Solution.Minesweeper(matrix);

            for (int i = 0; i < actual.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], actual[i]);
            }
        }
        static IEnumerable<object[]> MinesweeperJaggedArraysDynamic()
        {
            return new[] {
               new object[] { new[] { new[] { true, false, false }, new[] { false, true, false }, new[] { false, false, false } },
                              new[] { new[] { 1, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 1, 1 } } },
               new object[] { new[] { new[] { true, false, false }, new[] { false, true, false }, new[] { false, false, false } },
                                      new[] { new[] { 1, 2, 1 }, new[] { 2, 1, 1 }, new[] { 1, 1, 1 } } },
               new object[] { new[] { new[] { true, false, false, true }, new[] { false, false, true, false }, new[] { true, true, false, true } },
                                      new[] { new[] { 0, 2, 2, 1 }, new[] { 3, 4, 3, 3 }, new[] { 1, 2, 3, 1 } } },
               new object[] { new[] { new[] { true, true, true }, new[] { true, true, true }, new[] { true, true, true } },
                                      new[] { new[] { 3, 5, 3 }, new[] { 5, 8, 5 }, new[] { 3, 5, 3 } } },
               new object[] { new[] { new[] { false, true, true, false }, new[] { true, true, false, true }, new[] { false, false, true, false } },
                                      new[] { new[] { 3, 3, 3, 2 }, new[] { 2, 4, 5, 2 }, new[] { 2, 3, 2, 2 } }  },
               new object[] { new[] { new[] { true, false }, new[] { true, false }, new[] { false, true }, new[] { false, false }, new[] { false, false } },
                                      new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 1 }, new[] { 1, 1 }, new[] { 0, 0 } } }
            };
        }

        #endregion

        #region Rains of Reason

        [TestMethod]
        [DataRow(new[] { 1, 2, 1 }, 1, 3, new[] { 3, 2, 3 })]
        [DataRow(new[] { 2, 1 }, 3, 9, new[] { 2, 1 })]
        [DataRow(new[] { 1, 2, 1, 2, 1 }, 2, 1, new[] { 1, 1, 1, 1, 1 })]
        public void ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem, int[] expected)
        {
            var actual = Solution.ArrayReplace(inputArray, elemToReplace, substitutionElem);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(248622, true)]
        [DataRow(642386, false)]
        [DataRow(1, false)]
        [DataRow(8, true)]
        [DataRow(468402800, true)]
        [DataRow(5468428, false)]
        public void EvenDigitsOnly(int n, bool expected)
        {
            var actual = Solution.EvenDigitsOnly(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("var_1__Int", true)]
        [DataRow("qq-q", false)]
        [DataRow("2w2", false)]
        [DataRow(" variable", false)]
        [DataRow("va[riable0", false)]
        public void VariableName(string name, bool expected)
        {
            var actual = Solution.VariableName(name);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("crazy", "dsbaz")]
        [DataRow("z", "a")]
        [DataRow("aaaabbbccd", "bbbbcccdde")]
        [DataRow("fuzzy", "gvaaz")]
        [DataRow("codesignal", "dpeftjhobm")]
        public void AlphabeticShift(string inputString, string expected)
        {
            var actual = Solution.AlphabeticShift(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("A1", "C3", true)]
        [DataRow("A1", "H3", false)]
        [DataRow("A1", "A2", false)]
        [DataRow("A1", "B2", true)]
        [DataRow("B3", "H8", false)]
        [DataRow("C3", "B5", false)]
        public void ChessBoardCellColor(string cell1, string cell2, bool expected)
        {
            var actual = Solution.ChessBoardCellColor(cell1, cell2);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Through the Fog

        [TestMethod]
        [DataRow(10, 2, 7)]
        [DataRow(10, 7, 2)]
        [DataRow(4, 1, 3)]
        [DataRow(6, 3, 0)]
        [DataRow(18, 6, 15)]
        [DataRow(12, 10, 4)]
        [DataRow(18, 5, 14)]
        public void CircleOFNumbers(int n, int firstNumber, int expected)
        {
            var actual = Solution.CircleOfNumbers(n, firstNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(100, 20, 170, 3)]
        [DataRow(100, 1, 101, 1)]
        [DataRow(1, 100, 64, 6)]
        [DataRow(20, 20, 50, 6)]
        [DataRow(50, 25, 100, 4)]
        public void DepositProfit(int deposit, int rate, int threshold, int expected)
        {
            var actual = Solution.DepositProfit(deposit, rate, threshold);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { 2, 4, 7 }, 4)]
        public void AbsoluteValuesSumMinimization(int[] a, int expected)
        {
            var actual = Solution.AbsoluteValuesSumMinimization(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new[] { "aba", "bbb", "bab" }, false)]
        [DataRow(new[] { "ab", "bb", "aa" }, true)]
        [DataRow(new[] { "q", "q" }, false)]
        [DataRow(new[] { "zzzzab", "zzzzbb", "zzzzaa" }, true)]
        [DataRow(new[] { "ab", "ad", "ef", "eg" }, false)]
        [DataRow(new[] { "abc", "bef", "bcc", "bec", "bbc", "bdc" }, true)]
        [DataRow(new[] { "abc", "abx", "axx", "abc" }, false)]
        public void StringsRearrangement(string[] inputArray, bool expected)
        {
            var actual = Solution.StringsRearrangement(inputArray);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Diving Deeper

        [TestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, new[] { 1, 2, 4, 5, 7, 8, 10 })]
        [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 2, new[] { 1, 1, 1, 1 })]
        [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 10, new[] { 1, 2, 1, 2, 1, 2, 1, 2 })]
        [DataRow(new[] { 2, 4, 6, 8, 10 }, 2, new[] { 2, 6, 10 })]
        public void ExtractEachKth(int[] inputArray, int k, int[] expected)
        {
            var actual = Solution.ExtractEachKth(inputArray, k);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("var_1__Int", '1')]
        [DataRow("q2q-q", '2')]
        [DataRow("0ss", '0')]
        [DataRow("_Aas_23", '2')]
        [DataRow("a a_933", '9')]
        [DataRow("ok0", '0')]
        public void FirstDigit(string inputString, char expected)
        {
            var actual = Solution.FirstDigit(inputString);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("cabca", 3)]
        [DataRow("aba", 2)]
        [DataRow("ccccccccccc", 1)]
        [DataRow("bcaba", 3)]
        [DataRow("codesignal", 10)]
        public void DifferentSymbolsNaive(string s, int expected)
        {
            var actual = Solution.DifferentSymbolsNaive(s);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(new[] { 2, 3, 5, 1, 6 }, 2, 8)]
        [DataRow(new[] { 2, 4, 10, 1 }, 2, 14)]
        [DataRow(new[] { 1, 3, 2, 4 }, 3, 9)]
        [DataRow(new[] { 3, 2, 1, 1 }, 1, 3)]
        [DataRow(new[] { 1, 3, 4, 2, 4, 2, 4 }, 4, 13)]
        public void ArrayMaxConsecutiveSum(int[] inputArray, int k, int expected)
        {
            var actual = Solution.ArrayMaxConsecutiveSum(inputArray, k);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region Dark Wilderness

        [DataTestMethod]
        [DataRow(100, 10, 910, 10)]
        [DataRow(10, 9, 4, 1)]
        [DataRow(5, 2, 7, 2)]
        [DataRow(7, 3, 443, 110)]
        [DataRow(6, 5, 10, 5)]
        public void GrowingPlant(int upSpeed, int downSpeed, int desiredHeight, int expected)
        {
            var actual = Solution.GrowingPlant(upSpeed, downSpeed, desiredHeight);

            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(10, 5, 6, 4, 8, 10)]
        [DataRow(10, 5, 6, 4, 9, 16)]
        [DataRow(5, 3, 7, 4, 6, 7)]
        [DataRow(10, 2, 11, 3, 1, 0)]
        [DataRow(15, 2, 20, 3, 2, 15)]
        [DataRow(2, 5, 3, 4, 5, 3)]
        [DataRow(4, 3, 3, 4, 4, 4)]
        [DataRow(3, 5, 3, 8, 10, 3)]
        public void KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW, int expected)
        {
            var actual = Solution.KnapsackLight(value1, weight1, value2, weight2, maxW);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("123aa1", "123")]
        [DataRow("0123456789", "0123456789")]
        [DataRow("  3) always check for whitespaces", "")]
        [DataRow("12abc34", "12")]
        [DataRow("the output is 42", "")]
        [DataRow("aaaaaaa", "")]
        public void LongestDigitsPrefix(string inputString, string expected)
        {
            var actual = Solution.LongestDigitsPrefix(inputString);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(100, 1)]
        [DataRow(91, 2)]
        [DataRow(99, 2)]
        [DataRow(1000000000, 1)]
        [DataRow(9, 0)]
        [DataRow(877, 2)]
        [DataRow(777773, 3)]
        [DataRow(304, 1)]
        public void DigitDegree(int n, int expected)
        {
            var actual = Solution.DigitDegree(n);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("a1", "c3", true)]
        [DataRow("h1", "h3", false)]
        [DataRow("a5", "c3", true)]
        [DataRow("g1", "f3", false)]
        [DataRow("e7", "d6", true)]
        [DataRow("e7", "a3", true)]
        [DataRow("e3", "a7", true)]
        [DataRow("a1", "h8", true)]
        [DataRow("a1", "h7", false)]
        [DataRow("h1", "a8", true)]
        public void BishopAndPawn(string bishop, string pawn, bool expected)
        {
            var actual = Solution.BishopAndPawn(bishop, pawn);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region Eruption of Light

        [TestMethod]
        [DataRow("bbbaacdafe", true)]
        [DataRow("aabbb", false)]
        [DataRow("bbc", false)]
        [DataRow("bbbaa", false)]
        [DataRow("abcdefghijklmnopqrstuvwxyzz", false)]
        [DataRow("abcdefghijklmnopqrstuvwxyz", true)]
        [DataRow("abcdefghijklmnopqrstuvwxyzqwertuiopasdfghjklxcvbnm", true)]
        [DataRow("fyudhrygiuhdfeis", false)]
        [DataRow("zaa", false)]
        [DataRow("zyy", false)]
        public void IsBeautifulString(string inputString, bool expected)
        {
            var actual = Solution.IsBeautifulString(inputString);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("prettyandsimple@example.com", "example.com")]
        [DataRow("fully-qualified-domain@codesignal.com", "codesignal.com")]
        [DataRow("\" \"@space.com", "space.com")]
        [DataRow("someaddress@yandex.ru", "yandex.ru")]
        [DataRow("\" \"@xample.org", "xample.org")]
        [DataRow("\"much.more unusual\"@yahoo.com", "yahoo.com")]
        [DataRow("\"very.unusual.@.unusual.com\"@usual.com", "usual.com")]
        [DataRow("admin@mailserver2.ru", "mailserver2.ru")]
        [DataRow("example-indeed@strange-example.com", "strange-example.com")]
        [DataRow("very.common@gmail.com", "gmail.com")]
        public void FindEmailDomain(string address, string expected)
        {
            var actual = Solution.FindEmailDomain(address);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("abcdc", "abcdcba")]
        [DataRow("ababab", "abababa")]
        [DataRow("abba", "abba")]
        [DataRow("abaa", "abaaba")]
        [DataRow("aaaaba", "aaaabaaaa")]
        [DataRow("abc", "abcba")]
        [DataRow("kebab", "kebabek")]
        [DataRow("abccba", "abccba")]
        [DataRow("abcabc", "abcabcbacba")]
        [DataRow("cbdbedffcg", "cbdbedffcgcffdebdbc")]
        public void BuildPalindrome(string st, string expected)
        {
            var actual = Solution.BuildPalindrome(st);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(new[] { 2, 3, 5, 2 }, 3, 2)]
        [DataRow(new[] { 1, 3, 3, 1, 1 }, 0, 0)]
        [DataRow(new[] { 5, 1, 3, 4, 1 }, 0, 1)]
        [DataRow(new[] { 1, 1, 1, 1 }, 1, 4)]
        [DataRow(new[] { 1, 1, 1, 1 }, 0, 0)]
        [DataRow(new[] { 3, 1, 1, 3, 1 }, 2, 2)]
        public void ElectionsWinners(int[] votes, int k, int expected)
        {
            var actual = Solution.ElectionsWinners(votes, k);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("00-1B-63-84-45-E6", true)]
        [DataRow("Z1-1B-63-84-45-E6", false)]
        [DataRow("not a MAC-48 address", false)]
        [DataRow("FF-FF-FF-FF-FF-FF", true)]
        [DataRow("00-00-00-00-00-00", true)]
        [DataRow("G0-00-00-00-00-00", false)]
        [DataRow("02-03-04-05-06-07-", false)]
        [DataRow("12-34-56-78-9A-BC", true)]
        [DataRow("FF-FF-AB-CD-EA-BC", true)]
        [DataRow("12-34-56-78-9A-BG", false)]
        public void IsMAC48Address(string st, bool expected)
        {
            var actual = Solution.IsMAC48Address(st);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region Rainbow of Clarity

        [TestMethod]
        [DataRow('0', true)]
        [DataRow('-', false)]
        [DataRow('O', false)]
        [DataRow('1', true)]
        [DataRow('!', false)]
        public void IsDigit(char st, bool expected)
        {
            var actual = Solution.IsDigit(st);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("aabbbc", "2a3bc")]
        [DataRow("abbcabb", "a2bca2b")]
        [DataRow("abcd", "abcd")]
        [DataRow("zzzz", "4z")]
        [DataRow("wwwwwwwawwwwwww", "7wa7w")]
        [DataRow("ccccccccccccccc", "15c")]
        [DataRow("qwertyuioplkjhg", "qwertyuioplkjhg")]
        [DataRow("ssiiggkooo", "2s2i2gk3o")]
        public void LineEncoding(string st, string expected)
        {
            var actual = Solution.LineEncoding(st);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("a1", 2)]
        [DataRow("c2", 6)]
        [DataRow("d4", 8)]
        [DataRow("g6", 6)]
        [DataRow("a3", 4)]
        [DataRow("b7", 4)]
        [DataRow("h8", 2)]
        [DataRow("h6", 4)]
        [DataRow("g8", 3)]
        [DataRow("a5", 4)]
        public void ChessKnight(string cell, int expected)
        {
            var actual = Solution.ChessKnight(cell);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(152, 52)]
        [DataRow(1001, 101)]
        [DataRow(10, 1)]
        [DataRow(222219, 22229)]
        [DataRow(109, 19)]
        [DataRow(222250, 22250)]
        [DataRow(44435, 4445)]
        [DataRow(12, 2)]
        [DataRow(218616, 28616)]
        [DataRow(861452, 86452)]
        public void DeleteDigit(int cell, int expected)
        {
            var actual = Solution.DeleteDigit(cell);

            Assert.AreEqual(actual, expected);
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
            var actual = Solution.SeatsInTheater(nCols, nRows, col, row);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.MaxMultiple(divisor, bound);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.CircleOfNumbers(n, firstNumber);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.LateRide(n);

            Assert.AreEqual(expected, actual);
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
            var actual = Solution.PhoneCall(min1, min2_10, min11, s);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Ready, steady, go!", "steady")]
        [DataRow("Ready[[[, steady, go!", "steady")]
        [DataRow("ABCd", "ABCd")]
        [DataRow("To be or not to be", "not")]
        [DataRow("You are the best!!!!!!!!!!!! CodeFighter ever!", "CodeFighter")]
        public void LongestWord(string st, string expected)
        {
            var actual = Solution.LongestWord(st);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("13:58", true)]
        [DataRow("25:51", false)]
        [DataRow("02:76", false)]
        [DataRow("24:00", false)]
        [DataRow("02:61", false)]
        [DataRow("27:00", false)]
        [DataRow("19:66", false)]
        [DataRow("12:31", true)]
        [DataRow("25:73", false)]
        [DataRow("09:56", true)]
        [DataRow("03:29", true)]
        public void ValidTime(string st, bool expected)
        {
            var actual = Solution.ValidTime(st);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow("2 apples, 12 oranges", 14)]
        [DataRow("123450", 123450)]
        [DataRow("Your payment method is invalid", 0)]
        [DataRow("no digits at all", 0)]
        [DataRow("there are some (12) digits 5566 in this 770 string 239", 6587)]
        [DataRow("42+781", 823)]
        [DataRow("abc abc 4 abc 0 abc", 4)]
        [DataRow("abcdefghijklmnopqrstuvwxyz1AbCdEfGhIjKlMnOpqrstuvwxyz23,74 -", 98)]
        public void SumUpNumbers(string st, int expected)
        {
            var actual = Solution.SumUpNumbers(st);

            Assert.AreEqual(actual, expected);
        }


        #endregion
    }
}
