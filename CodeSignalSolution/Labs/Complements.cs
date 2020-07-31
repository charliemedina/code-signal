using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Labs
{
    public static class Complements
    {
        #region #1 Rotate Matrix

        public static void RotateMatrix(int[,] matriz, int rotaciones)
        {
            var rotates = rotaciones % 4;

            if (rotates >= 0)
            {
                RotateMatrixAux(matriz, rotaciones);
            }
            else
            {
                RotateMatrix(matriz, 4 + rotates);
            }
        }
        private static void RotateMatrixAux(int[,] matriz, int rotaciones)
        {
            while (rotaciones > 0)
            {
                RightRotate(matriz);
                rotaciones--;
            }
        }
        private static void RightRotate(int[,] matriz)
        {
            var len = matriz.GetLength(0);
            var temp = new int[len, len];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    temp[j, len - i - 1] = matriz[i, j];
                }
            }

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    matriz[i, j] = temp[i, j];
                }
            }
        }

        #endregion

        #region #2 ParseInt
        public static int ParseInt(string numero, char[] digitosBase)
        {
            var result = 0;
            var @base = digitosBase.Length;
            var len = numero.Length;

            for (int i = 0; i < len; i++)
            {
                var dB = new string(digitosBase);
                var n = dB.IndexOf(numero[i]);

                result += n * (int)Math.Pow(@base, len - i - 1);
            }

            return result;
        }
        public static string IntToString(int n, char[] digitosBase)
        {
            var @base = digitosBase.Length;
            var result = String.Empty;
            var dB = new string(digitosBase);

            while (n / @base > 0)
            {
                result = dB[n % @base] + result;
                n /= @base;
            }

            return dB[n % @base] + result;
        }

        #endregion

        #region #3 Locate Airport

        public static int LocateAirport(int[,] terreno, int alto, int ancho)
        {
            var lowerHeigth = int.MaxValue;

            var m = terreno.GetLength(0);
            var n = terreno.GetLength(1);

            for (int i = 0; i + alto <= m; i++)
            {
                for (int j = 0; j + ancho <= n; j++)
                {
                    var min = int.MaxValue;
                    var max = int.MinValue;

                    for (int k = i; k < i + alto; k++)
                    {
                        for (int l = j; l < j + ancho; l++)
                        {
                            min = Math.Min(min, terreno[k, l]);
                            max = Math.Max(max, terreno[k, l]);
                        }
                    }
                    lowerHeigth = Math.Min(lowerHeigth, max - min);
                }
            }
            return lowerHeigth;
        }
        public static int[] GetDimensions(int[,] terreno, int alto, int ancho)
        {
            var lowerHeigth = int.MaxValue;

            var m = terreno.GetLength(0);
            var n = terreno.GetLength(1);

            var coordinates = new int[4];

            for (int i = 0; i + alto <= m; i++)
            {
                for (int j = 0; j + ancho <= n; j++)
                {
                    var min = int.MaxValue;
                    var max = int.MinValue;

                    for (int k = i; k < i + alto; k++)
                    {
                        for (int l = j; l < j + ancho; l++)
                        {
                            min = Math.Min(min, terreno[k, l]);
                            max = Math.Max(max, terreno[k, l]);
                        }
                    }
                    if (lowerHeigth > max - min)
                    {
                        lowerHeigth = max - min;
                        coordinates[0] = i;
                        coordinates[1] = j;
                        coordinates[2] = i + alto - 1;
                        coordinates[3] = j + ancho - 1;
                    }
                }
            }
            return coordinates; ;
        }

        #endregion

        #region #4 Anagrams

        public static bool AreAnagrams(string a, string b)
        {
            var aa = string.Concat(a.OrderBy(c => c));
            var bb = string.Concat(b.OrderBy(c => c));

            return aa == bb;
        }

        public static int LargestAnagramsSet(string[] words, int n)
        {
            var maxSize = 0;

            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < n ; i++)
            {
                char[] temp = words[i].ToCharArray();
                Array.Sort(temp);

                words[i] = new string(temp);

                if (count.ContainsKey(words[i]))
                {
                    count[words[i]]++;
                }
                else 
                {
                    count.Add(words[i], 1);
                }
                maxSize = Math.Max(maxSize, count[words[i]]);
            }
            return maxSize;
        }

        public static string[] LargestAnagramsSet(string[] words)
        {
            var maxSize = 0;
            var maxKey = string.Empty;

            Dictionary<string, List<string>> set = new Dictionary<string, List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                char[] temp = words[i].ToCharArray();
                Array.Sort(temp);

                var key = new string(temp);

                if (set.ContainsKey(key))
                {
                    set[key].Add(words[i]);
                }
                else
                {
                    var anagrams = new List<string>
                    {
                        words[i]
                    };
                    set.Add(key, anagrams);
                }
                if (maxSize < set[key].Count())
                {
                    maxSize = set[key].Count();
                    maxKey = key;
                }
            }
            return string.IsNullOrEmpty(maxKey) ? words : set[maxKey].ToArray();
        }

        #endregion

        #region #5 Maximum SubArray Sum

        public static int MaxSubArraySum(int[] array)
        {
            var maxSum = int.MinValue;
            var currentSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }

            }
            return maxSum;
        }

        #endregion

        #region #6 Multiply Polynomials

        public static int[] MultiplyPolynomials(int[] p1, int[] p2)
        {
            var m = p1.Length;
            var n = p2.Length;

            var result = new int[m + n - 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i + j] += p1[i] * p2[j];
                }
            }
            return result;
        }

        #endregion

        #region #7 Closet Sort

        public static void ClosetSort(int[] array, int pivot)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[j] - pivot) < Math.Abs(array[i] - pivot))
                    {
                        Swap(array, i, j);
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        #endregion

        #region #8 FourInLine

        public static bool FourInLine(bool[,] board)
        {
            var coord = new Point[] {
                new Point { X = 1, Y = 0 }, 
                new Point { X = 0, Y = 1 }, 
                new Point { X = 1, Y = 1 } 
            };

            var rows = board.GetLength(0);
            var columns = board.GetLength(1);

            var numberInLine = 4;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    var type = board[x, y];

                    for (int k = 0; k < coord.Length; k++)
                    {
                        if (IsInside(x, y, coord[k], numberInLine - 1, rows, columns))
                        {
                            var count = 1;

                            for (int size = 0; size < numberInLine; size++)
                            {
                                if (type == board[x + coord[k].X * size, y + coord[k].Y * size])
                                {
                                    count++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (count == numberInLine)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static bool ItIsInTheSoup(char[,] soup, string word)
        {
            var coord = new Point[] {
                new Point { X = 1, Y = 0 },
                new Point { X = 0, Y = 1 },
                new Point { X = -1, Y = 0 },
                new Point { X = 0, Y = -1 },
                new Point { X = 1, Y = 1 },
                new Point { X = -1, Y = -1 },
                new Point { X = -1, Y = 1 },
                new Point { X = 1, Y = -1 },
            };

            var rows = soup.GetLength(0);
            var columns = soup.GetLength(1);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    for (int k = 0; k < coord.Length; k++)
                    {
                        if (IsInside(x, y, coord[k], word.Length, rows, columns))
                        {
                            var count = 0;
                            for (int size = 0; size < word.Length; size++)
                            {
                                if (word[size] == soup[x + coord[k].X * size, y + coord[k].Y * size])
                                {
                                    count++;
                                }
                                else 
                                {
                                    break;
                                }
                            }
                            if (count == word.Length)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private static bool IsInside(int x, int y, Point point, int len, int rows, int columns)
        {
            return 0 <= x + point.X * len && x + point.X * len < rows && 0 <= y + point.Y * len && y + point.Y * len < columns;
        }

        #endregion

        #region #9 Magic Square

        public static bool IsMagicSquare(int[,] matrix)
        {
            var n = matrix.GetLength(0);
            int d1 = 0, d2 = 0;

            // the prime diagonal 
            for (int i = 0; i < n; i++)
            {
                d1 += matrix[i, i];
            }

            // the secondary diagonal 
            for (int i = 0; i < n; i++)
            {
                d2 += matrix[i, n - 1 - i];
            }

            if (d1 != d2) { return false; }

            // sums of rows 
            for (int i = 0; i < n; i++)
            {
                var rowSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += matrix[i, j];
                }

                if (rowSum != d1) { return false; }
            }

            // sums of columns 
            for (int i = 0; i < n; i++)
            {
                var colSum = 0;
                for (int j = 0; j < n; j++)
                {
                    colSum += matrix[j, i];
                }

                if (d1 != colSum) { return false; } 
                    
            }
            return true;
        }

        #endregion

        #region #10 SubMatrix

        public static int[,] SubMatrix(int[,] original, int row, int column)
        {
            var rows = original.GetLength(0);
            var columns = original.GetLength(1);

            var result = new int[rows - 1, columns - 1];

            int i = 0;
            for (int x = 0; x < rows; x++)
            {
                if (x < row)
                {
                    i = x;
                }
                else if (i == row)
                {
                    continue;
                }
                else
                {
                    i = x - 1;
                }
                for (int y = 0; y < columns; y++)
                {
                    int j;
                    if (y < column)
                    {
                        j = y;
                    }
                    else if (y == column)
                    {
                        continue;
                    }
                    else
                    {
                        j = y - 1;
                    }
                    result[i, j] = original[x, y];
                }
            }
            return result;
        }

        #endregion
    }
}
