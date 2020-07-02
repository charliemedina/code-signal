using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace CodeSignalSolution
{
    public class Solution
    {
        /**************      Intro     **************/

        #region The Journey Begins

        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }

        public static int CenturyFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public static bool CheckPalindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());
        }

        #endregion

        #region Edge of the Ocean

        public static int AdjacentElementsProduct(int[] inputArray)
        {
            var maxProduct = int.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int x = inputArray[i];
                int y = inputArray[i + 1];
                if (x * y > maxProduct)
                {
                    maxProduct = x * y;
                }
            }

            return maxProduct;
        }

        public static int ShapeArea(int n)
        {
            return n == 1 ? 1 : (n * 4) - 4 + ShapeArea(n - 1);
        }

        public static int MakeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);

            var length = statues.Length;
            var max = statues[length - 1];
            var min = statues[0];

            return max - min - length + 1;
        }

        public static bool AlmostIncreasingSequence(int[] sequence)
        {
            bool oneBreak = false;

            for (int i = -1, j = 0, k = 1; k < sequence.Length; k++)
            {
                bool deleteCurrent = false;

                if (sequence[j] >= sequence[k])
                {
                    if (oneBreak)
                    {
                        return false;
                    }
                    oneBreak = true;

                    if (k > 1 && sequence[i] >= sequence[k])
                    {
                        deleteCurrent = true;
                    }
                }

                if (!oneBreak)
                {
                    i = j;
                }

                if (!deleteCurrent)
                {
                    j = k;
                }
            }

            return true;
        }

        public static int MatrixElementsSum(int[][] matrix)
        {
            int totalSum = 0;

            for (int column = 0; column < matrix[0].Length; column++)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][column] != 0)
                    {
                        totalSum += matrix[row][column];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return totalSum;
        }

        #endregion

        #region Smooth Sailing

        public static string[] AllLongestStrings(string[] inputArray)
        {
            if (inputArray.Length == 1)
            {
                return inputArray;
            }

            var result = inputArray[0];
            var maxLenght = result.Length;

            for (int i = 1; i < inputArray.Length; i++)
            {
                var currentLength = inputArray[i].Length;
                var currentString = inputArray[i];

                if (maxLenght == currentLength)
                {
                    result += "," + currentString;
                }
                if (maxLenght < currentLength)
                {
                    result = currentString;
                    maxLenght = currentLength;
                }
            }

            return result.Split(',');
        }

        public static int CommonCharacterCount(string s1, string s2)
        {
            var min = s1.Length >= s2.Length ? s1 : s2;
            var max = min.Length == s1.Length ? s2 : s1;

            var marks = new bool[max.Length];

            int count = 0;

            for (int i = 0; i < min.Length; i++)
            {
                for (int j = 0; j < max.Length; j++)
                {
                    if (min[i] == max[j] && !marks[j])
                    {
                        count++;
                        marks[j] = true;
                        break;
                    }
                }
            }

            return count;
        }

        public static bool IsLucky(int n)
        {
            var s = n.ToString();

            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                sum1 += s[i] - '0';
                sum2 += s[s.Length - i - 1] - '0';
            }

            return sum1 == sum2;

            //var N = n.ToString();
            //n = N.Length / 2;
            //return N.Substring(n).Sum(_ => _ - '0') == N.Remove(n).Sum(_ => _ - '0');
        }

        public static bool IsLucky1(int n)
        {
            var s = n.ToString();

            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                sum1 += s[i] - '0';
                sum2 += s[s.Length - i - 1] - '0';
            }

            return sum1 == sum2;

            //var N = n.ToString();
            //n = N.Length / 2;
            //return N.Substring(n).Sum(_ => _ - '0') == N.Remove(n).Sum(_ => _ - '0');
        }

        public static int[] SortByHeight(int[] a)
        {
            var indexes = new List<int>();
            var values = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    indexes.Add(i);
                    values.Add(a[i]);
                }
            }

            values.Sort();

            for (int i = 0; i < values.Count; i++)
            {
                a[indexes[i]] = values[i];
            }

            return a;
        }

        public static string ReverseInParentheses(string inputString)
        {
            int lastOpenParen = inputString.LastIndexOf('(');

            if (lastOpenParen == -1)
            {
                return inputString;
            }
            else
            {
                int firstClosedParen = inputString.IndexOf(')', lastOpenParen);

                return ReverseInParentheses(
                    inputString.Substring(0, lastOpenParen)
                    + new string(inputString.Substring(lastOpenParen + 1, firstClosedParen - lastOpenParen - 1).Reverse().ToArray())
                    + inputString.Substring(firstClosedParen + 1));
            }
        }

        #endregion

        #region Exploring the Waters

        public static int[] AlternatingSums(int[] a)
        {
            int team1 = 0, team2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    team1 += a[i];
                }
                else
                {
                    team2 += a[i];
                }
            }

            return new[] { team1, team2 };
        }

        public static string[] AddBorder(string[] picture)
        {
            List<string> result = new List<string>();

            string horizontalBorder = new string('*', picture.First().Length + 2);

            result.Add(horizontalBorder);

            for (var i = 0; i < picture.Length; i++)
            {
                string row = "*";
                for (var j = 0; j < picture[0].Length; j++)
                {
                    row += picture[i][j];
                }
                row += "*";
                result.Add(row);
            }
            result.Add(horizontalBorder);
            return result.ToArray();
        }

        public static bool AreSimilar(int[] a, int[] b)
        {
            var swapCount = a.Select((n, i) => i).Where(n => a[n] != b[n]).Count();

            Array.Sort(a);
            Array.Sort(b);
            if (!a.SequenceEqual(b))
            {
                return false;
            }

            return swapCount <= 2;
        }

        public static int ArrayChange(int[] inputArray)
        {
            var moves = 0;

            for (var i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= inputArray[i - 1])
                {
                    var diff = inputArray[i - 1] - inputArray[i] + 1;
                    inputArray[i] += diff;
                    moves += diff;
                }
            }

            return moves;
        }

        public static bool PalindromeRearranging(string inputString)
        {
            return inputString.GroupBy(c => c)
                .Where(g => g.Count() % 2 != 0)
                .Count() <= 1;
        }

        #endregion

        #region Island of Knowledge

        public static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight)
                && yourLeft + yourRight == friendsLeft + friendsRight;
        }

        public static int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int max = int.MinValue;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int diff = Math.Abs(inputArray[i] - inputArray[i + 1]);
                if (diff > max)
                {
                    max = diff;
                }
            }
            return max;
        }

        public static bool IsIPv4Address(string inputString)
        {
            var ips = inputString.Split('.');
            if (ips.Length != 4)
            {
                return false;
            }
            foreach (var s in ips)
            {
                if (!int.TryParse(s, out int ip) || s[0] == '0' && s.Length > 1)
                {
                    return false;
                }
                else
                {
                    if (ip < 0 || ip > 255)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int AvoidObstacles(int[] inputArray)
        {
            int len = inputArray.Length;
            int jump = 2;

            while (true)
            {
                for (int i = 0; i < len; i++)
                {
                    if (inputArray[i] % jump == 0)
                    {
                        break;
                    }
                    if (i == len - 1)
                    {
                        return jump;
                    }
                }
                jump++;
            }

            //int n = 2;
            //while (inputArray.Any(_ => _ % n < 1))
            //{
            //    n++;
            //}
            //return n;
        }

        #endregion

        /**************      The Core     **************/

        #region Intro Gates

        public static int AddTwoDigits(int n)
        {
            return n / 10 + n % 10;
        }

        public static int LargestNumber(int n)
        {
            return (int)Math.Pow(10, n) - 1;
        }

        public static int Candies(int n, int m)
        {
            return n * (m / n);
        }

        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }

        public static int MaxMultiple(int divisor, int bound)
        {
            return (bound / divisor) * divisor;
        }

        public static int CircleOfNumbers(int n, int firstNumber)
        {
            int half = n / 2;
            return half > firstNumber ? half + firstNumber : firstNumber - half;
        }

        public static int LateRide(int n)
        {
            var hours = n / 60;
            var minutes = n % 60;

            return hours / 10 + hours % 10 + minutes / 10 + minutes % 10;
        }

        public static int PhoneCall(int min1, int min2_10, int min11, int s)
        {
            if (s < min1)
            {
                return 0;
            }
            if (s < min1 + min2_10 * 9)
            {
                return 1 + (s - min1) / min2_10;
            }
            return 10 + (s - min1 - min2_10 * 9) / min11;
        }

        #endregion
    }
}
