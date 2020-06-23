using System;
using System.Linq;

namespace CodeSignalSolution
{
    public class Solution
    {
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

        #endregion
    }
}
