using System;
using System.Diagnostics;
using System.Linq;

namespace Labs
{
    class Program
    {
        static void Main()
        {
            var sw = new Stopwatch();
            long elapsedTime1, elapsedTime2;

            #region Adjacent Element Product

            sw.Start();
            _ = MyAdjacentElementsProduct(new[] { 9, 5, 10, 2, 24, -1, -48 });
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = AdjacentElementsProduct(new[] { 9, 5, 10, 2, 24, -1, -48 });
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n********* Adjacent Element Product **********\n");
            Console.WriteLine($"MyAdjacentElementsProduct is : {elapsedTime1}ms\nAdjacentElementsProduct is : {elapsedTime2}ms");

            #endregion

            #region Shape Area

            sw.Start();
            _ = MyShapeArea(9999);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = ShapeArea(9999);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n********* Shape Area **********\n");
            Console.WriteLine($"MyShapeArea is : {elapsedTime1}ms\nShapeArea is : {elapsedTime2}ms");

            #endregion

            #region Make Array Consecutive 2

            sw.Start();
            _ = MyMakeArrayConsecutive2Solution(new[] { 6, 2, 3, 8 });
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = MakeArrayConsecutive2Solution2(new[] { 6, 2, 3, 8 });
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n********* Make Array Consecutive 2 **********\n");
            Console.WriteLine($"MyMakeArrayConsecutive2 is : {elapsedTime1}ms\nMakeArrayConsecutive2 is : {elapsedTime2}ms");

            #endregion

            #region Almost Increasing Sequence

            sw.Start();
            _ = MyAlmostIncreasingSequence(new[] { 123, -17, -5, 1, 2, 3, 12, 43, 45 });
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = AlmostIncreasingSequence(new[] { 123, -17, -5, 1, 2, 3, 12, 43, 45 });
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n********* Almost Increasing Sequence **********\n");
            Console.WriteLine($"MyAlmostIncreasingSequence is : {elapsedTime1}ms\nAlmostIncreasingSequence is : {elapsedTime2}ms");

            #endregion

            Console.ReadLine();
        }

        public static int MyAdjacentElementsProduct(int[] inputArray)
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
        public static int AdjacentElementsProduct(int[] inputArray)
        {
            return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
        }

        public static int MyShapeArea(int n)
        {
            return n == 1 ? 1 : (n * 4) - 4 + MyShapeArea(n - 1);
        }
        public static int ShapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }

        public static int MyMakeArrayConsecutive2Solution(int[] statues)
        {
            Array.Sort(statues);

            var length = statues.Length;
            var max = statues[length - 1];
            var min = statues[0];

            return max - min - length + 1;
        }
        public static int MakeArrayConsecutive2Solution2(int[] statues)
        {
            return statues.Max() - statues.Min() - statues.Length + 1;
        }

        public static bool MyAlmostIncreasingSequence(int[] sequence)
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
        public static bool AlmostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 2) { return true; }
            int countOne = 0;
            int countTwo = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    countOne++;
                }
                if (i != 0)
                {
                    if (sequence[i - 1] >= sequence[i + 1])
                    {
                        countTwo++;
                    }
                }
            }

            if (countOne == 1 && countTwo <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
