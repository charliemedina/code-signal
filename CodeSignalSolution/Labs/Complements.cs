using System;
using System.Collections.Generic;
using System.Linq;

namespace Labs
{
    public static class Complements
    {
        #region #1

        public static void RotaMatriz(int[,] matriz, int rotaciones)
        {
            var rotates = rotaciones % 4;

            if (rotates >= 0)
            {
                RotaMatrizAux(matriz, rotaciones);
            }
            else
            {
                RotaMatriz(matriz, 4 + rotates);
            }
        }
        private static void RotaMatrizAux(int[,] matriz, int rotaciones)
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

        #region #2
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

        #region #3

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

        #region #4

        public static bool AreAnagrams(string a, string b)
        {
            var aa = string.Concat(a.OrderBy(c => c));
            var bb = string.Concat(b.OrderBy(c => c));

            return aa == bb;
        }

        public static int LargestSubsetOfAnagrams(string[] words)
        {
            var max = int.MinValue;

            for (int i = 0; i < words.Length - 1; i++)
            {
                var sum = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    if (AreAnagrams(words[i], words[j]))
                    {
                        sum++;
                    }
                }
                max = Math.Max(max, sum);
            }
            return max;
        }

        public static IEnumerable<string> LargestGroupOfAnagrams(string[] words)
        {
            var max = int.MinValue;
            var largetGroup = new List<string>();

            for (int i = 0; i < words.Length - 1; i++)
            {
                var count = 0;
                var group = new List<string>();
                for (int j = 0; j < words.Length; j++)
                {
                    if (AreAnagrams(words[i], words[j]))
                    {
                        count++;
                        group.Add(words[j]);
                    }
                }
                if (count > max)
                {
                    max = count;
                    largetGroup = group;
                }
            }
            return largetGroup;
        }

        #endregion
    }
}
