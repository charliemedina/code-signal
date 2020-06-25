using System;
using System.Linq;

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
