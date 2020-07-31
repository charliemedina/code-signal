using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Labs
{
    class Program
    {
        static void Main()
        {
            var sw = new Stopwatch();
            long elapsedTime1, elapsedTime2;

            Console.WriteLine("\n--------------------------------------------- Code Signal ---------------------------------------------");

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

            Console.WriteLine("\n - Adjacent Element Product\n");
            Console.WriteLine($"\tMyAdjacentElementsProduct is : {elapsedTime1}ms\n\tAdjacentElementsProduct is : {elapsedTime2}ms");

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

            Console.WriteLine("\n- Shape Area\n");
            Console.WriteLine($"\tMyShapeArea is : {elapsedTime1}ms\n\tShapeArea is : {elapsedTime2}ms");

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

            Console.WriteLine("\n- Make Array Consecutive 2\n");
            Console.WriteLine($"\tMyMakeArrayConsecutive2 is : {elapsedTime1}ms\n\tMakeArrayConsecutive2 is : {elapsedTime2}ms");

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

            Console.WriteLine("\n- Almost Increasing Sequence\n");
            Console.WriteLine($"\tMyAlmostIncreasingSequence is : {elapsedTime1}ms\n\tAlmostIncreasingSequence is : {elapsedTime2}ms");

            #endregion

            #region Matrix Element Sum

            int[] array1 = new int[4] { 0, 1, 1, 2 };
            int[] array2 = new int[4] { 0, 5, 0, 0 };
            int[] array3 = new int[4] { 2, 0, 3, 3 };
            int[][] matrix = new int[][] { array1, array2, array3 };


            sw.Start();
            _ = MyMatrixElementsSum(matrix);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = MatrixElementsSum(matrix);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- Matrix Element Sum\n");
            Console.WriteLine($"\tMyMatrixElementsSum is : {elapsedTime1}ms\n\tMatrixElementsSum is : {elapsedTime2}ms");

            #endregion

            #region All Longest Strings

            var inputArray = new[] { "young", "yooooooung", "hot", "or", "not", "come", "on", "fire", "water", "watermelon" };

            sw.Start();
            _ = MyAllLongestStrings(inputArray);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = AllLongestStrings(inputArray);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- All Longest Strings\n");
            Console.WriteLine($"\tMyAllLongestStrings is : {elapsedTime1}ms\n\tAllLongestStrings is : {elapsedTime2}ms");

            #endregion

            #region Common Character Count

            var s1 = "abca";
            var s2 = "xyzbac";

            sw.Start();
            _ = MyCommonCharacterCount(s1, s2);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = CommonCharacterCount(s1, s2);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- Common Character Count\n");
            Console.WriteLine($"\tMyCommonCharacterCount is : {elapsedTime1}ms\n\tCommonCharacterCount is : {elapsedTime2}ms");

            #endregion

            #region My Sort By Height

            var heights = new[] { -1, 150, 190, 170, -1, -1, 160, 180 };

            sw.Start();
            _ = MySortByHeight(heights);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = SortByHeight(heights);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- Common Character Count\n");
            Console.WriteLine($"\tMySortByHeight is : {elapsedTime1}ms\n\tSortByHeight is : {elapsedTime2}ms");

            #endregion

            #region Reverse In Parentheses

            var inputString = "foo(bar(baz))blim";

            sw.Start();
            _ = MyReverseInParentheses(inputString);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = ReverseInParentheses(inputString);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- Reverse In Parentheses\n");
            Console.WriteLine($"\tMyReverseInParentheses is : {elapsedTime1}ms\n\tSortByHeight is : {elapsedTime2}ms");

            #endregion

            #region Add Border

            var picture = new[] { "abcde", "fghij", "klmno", "pqrst", "uvwxy" };

            sw.Start();
            _ = MyAddBorder(picture);
            sw.Stop();
            elapsedTime1 = sw.ElapsedMilliseconds;
            sw.Reset();

            sw.Start();
            _ = AddBorder(picture);
            sw.Stop();
            elapsedTime2 = sw.ElapsedMilliseconds;
            sw.Reset();

            Console.WriteLine("\n- Add Border\n");
            Console.WriteLine($"\tMyAddBorder is : {elapsedTime1}ms\n\tAddBorder is : {elapsedTime2}ms");

            #endregion

            #region Complements

            Console.WriteLine("\n--------------------------------------------- Complements ---------------------------------------------");

            Console.WriteLine("\n- Rotar Matrices\n");
            int[,] matrix1 = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            Complements.RotateMatrix(matrix1, 2);
            Print2DArray(matrix1);

            Console.WriteLine();

            int[,] matrix2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Complements.RotateMatrix(matrix2, -3);
            Print2DArray(matrix2);

            Console.WriteLine("\n- Sistemas de Numeración\n");
            Console.WriteLine($"\tParseInt is : {Complements.ParseInt("baac", new[] { 'a', 'b', 'c' })}");

            Console.WriteLine("\n- Int To String\n");
            Console.WriteLine($"\tIntToString is : {Complements.IntToString(29, new[] { 'a', 'b', 'c' })}");

            Console.WriteLine("\n- Construcción de Aeropuerto\n");
            int[,] terreno = new int[4, 6] { { 4, 3, 5, 1, 2, 1 }, { 2, 7, 6, 3, 2, 3 }, { 3, 8, 5, 2, 2, 3 }, { 5, 7, 6, 4, 2, 3 } };
            Print2DArray(terreno);
            Console.WriteLine($"\n\tLocateAirport is : {Complements.LocateAirport(terreno, 3, 2)}\n");
            PrintArray(Complements.GetDimensions(terreno, 3, 2));

            Console.WriteLine("\n- Anagramas\n");
            var a = "casa";
            var b = "saca";
            Console.WriteLine($"\tAre Anagrams \"{a}\" and \"{b}\": {Complements.AreAnagrams(a, b)}\n");
            
            var words = new string[] { "amor", "cometa", "roma", "mora", "moceta" };
            Console.WriteLine($"\tThe largest subset of anagrams for...");
            PrintArray(words);
            Console.WriteLine($"\tis: {Complements.LargestAnagramsSet(words, words.Length)}. This subset is...\n");
            var words1 = new string[] { "amor", "cometa", "roma", "mora", "moceta" };
            var largestSubset = Complements.LargestAnagramsSet(words1);
            PrintArray(largestSubset.ToArray());

            Console.WriteLine("\n- Max SubArray Sum\n");
            var array = new[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            PrintArray(array);
            Console.WriteLine($"\tThe consecutive maximum sum is: {Complements.MaxSubArraySum(array)}\n");

            Console.WriteLine("\n- Multiply Polynomials\n");
            var p1 = new[] { -3, 2, 5 };
            var p2 = new[] { 4, 2 };

            PrintPolynomios(p1);
            PrintPolynomios(p2);
            Console.WriteLine($"\tResult is:\n");
            PrintPolynomios(Complements.MultiplyPolynomials(p1, p2));

            Console.WriteLine("\n- Closet Sort\n");
            var arr = new[] { 5, 3 , 7, 10 };
            var pivot = 7;
            PrintArray(arr);
            Console.WriteLine($"\tSort by closet with pivot equal {pivot} is:\n");
            Complements.ClosetSort(arr, pivot);
            PrintArray(arr);

            Console.WriteLine("\n- 4 in Line\n");
            var board = new bool[,] {
                { true, true, false, true},
                { true, true, false, true},
                { false, true, true, false},
                { true, false, true, true}
            };

            Print2DArray(board);
            Console.WriteLine($"\tThere are 4 in line is: {Complements.FourInLine(board)}\n");

            Console.WriteLine("\n- IsInTheSoup\n");

            var soup = new char[,] {
                { '*', 'I', 't', 'C', '*'},
                { '*', 't', 'a', 'a', '*'},
                { '*', 'a', 'a', 'm', '*'},
                { '*', 'l', 'z', '*', '*'}
            };
            var word = "Iam";

            Print2DArray(soup);
            Console.WriteLine($"\tIs \"{word}\" in the soup: {Complements.ItIsInTheSoup(soup, word)}\n");

            Console.WriteLine("\n- Is Magic Square\n");

            var magic = new int[,] {
                { 2, 7, 6 },
                { 9, 5, 1 },
                { 4, 3, 8 }
            };

            Print2DArray(magic);
            Console.WriteLine($"\tIs magic square : {Complements.IsMagicSquare(magic)}\n");

            Console.WriteLine("\n- Sub Matrix\n");

            var original = new int[,] {
                { 1, 2, 2, 4, 5 },
                { 0, 2, 1, 1, 1 },
                { 3, 0, 1, 3, 2 },
                { 7, 7, 0, 5, 2 }
            };

            Print2DArray(original);
            var row = 2; var column = 3;
            Console.WriteLine($"\tthe result of removing row {row} and column {column} is is the submatrix: \n");

            Print2DArray(Complements.SubMatrix(original, row, column));

            #endregion

            Console.ReadKey();
        }

        static int MyAdjacentElementsProduct(int[] inputArray)
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
        static int AdjacentElementsProduct(int[] inputArray)
        {
            return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();
        }

        static int MyShapeArea(int n)
        {
            return n == 1 ? 1 : (n * 4) - 4 + MyShapeArea(n - 1);
        }
        static int ShapeArea(int n)
        {
            return n * n + (n - 1) * (n - 1);
        }

        static int MyMakeArrayConsecutive2Solution(int[] statues)
        {
            Array.Sort(statues);

            var length = statues.Length;
            var max = statues[length - 1];
            var min = statues[0];

            return max - min - length + 1;
        }
        static int MakeArrayConsecutive2Solution2(int[] statues)
        {
            return statues.Max() - statues.Min() - statues.Length + 1;
        }

        static bool MyAlmostIncreasingSequence(int[] sequence)
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
        static bool AlmostIncreasingSequence(int[] sequence)
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

        static int MyMatrixElementsSum(int[][] matrix)
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
        static int MatrixElementsSum(int[][] matrix)
        {
            int r = 0;
            for (int i = 0; i < matrix[0].Length; i++)
                for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
                    r += matrix[j][i];

            return r;
        }

        static string[] MyAllLongestStrings(string[] inputArray)
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
        static object AllLongestStrings(string[] inputArray)
        {
            int len = inputArray.Max(_ => _.Length);
            return inputArray.Where(_ => _.Length == len);
        }

        static int MyCommonCharacterCount(string s1, string s2)
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
        static int CommonCharacterCount(string s1, string s2)
        {
            return s1.Distinct().Sum(_ => Math.Min(s1.Count(l => l == _), s2.Count(l => l == _)));
        }

        static int[] MySortByHeight(int[] a)
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
        static object SortByHeight(int[] a)
        {
            var people = a.Where(p => p >= 0).OrderBy(p => p).ToArray();
            int i = 0;

            return a.Select(p => p >= 0 ? people[i++] : -1);
        }

        static string MyReverseInParentheses(string inputString)
        {
            int lastOpenParen = inputString.LastIndexOf('(');

            if (lastOpenParen == -1)
            {
                return inputString;
            }
            else
            {
                int firstClosedParen = inputString.IndexOf(')', lastOpenParen);

                return MyReverseInParentheses(
                    inputString.Substring(0, lastOpenParen)
                    + new string(inputString.Substring(lastOpenParen + 1, firstClosedParen - lastOpenParen - 1).Reverse().ToArray())
                    + inputString.Substring(firstClosedParen + 1));
            }
        }
        static string ReverseInParentheses(string inputString)
        {
            while (inputString.Contains("("))
            {
                int i = inputString.LastIndexOf("(");
                var s = new string(inputString.Skip(i + 1).TakeWhile(x => x != ')').Reverse().ToArray());
                var t = "(" + new string(s.Reverse().ToArray()) + ")";
                inputString = inputString.Replace(t, s);
            }
            return inputString;
        }

        static string[] MyAddBorder(string[] picture)
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
        static string[] AddBorder(string[] picture)
        {
            var stars = new string[] { new string('*', picture[0].Length + 2) };
            return stars.Concat(picture.Select(s => "*" + s + "*"))
                .Concat(stars)
                .ToArray();
        }

        static void PrintArray<T>(T[] array)
        {
            Console.Write("\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "   ");
            }
            Console.WriteLine("\n");
        }
        static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        static void PrintPolynomios(int[] p)
        {
            var n = p.Length;

            Console.Write("\t");
            for (int i = 0; i < n; i++)
            {
                Console.Write(p[i]);
                if (i != 0)
                {
                    Console.Write("x^" + i);
                }
                if (i != n - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
