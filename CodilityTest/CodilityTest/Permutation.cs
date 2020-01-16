using System;
using System.Collections.Generic;

namespace CodilityTest
{
    public class Permutation
    {
        public Permutation()
        {
        }
        public int Permutations(int a, int b)
        {
            int c = 1;
            int d = a - b;
            if (d == 0)
            {
                d = 1;
            }
            for (int i = a; i > d; i--)
            {
                c *= i;
            }
            return c;
        }
        public int[][] AllPossibleWaysExt(int[] a)
        {
            int Jarraylenth = 0;
            for (int i = 1; i <= a.Length; i++)
            {
                Jarraylenth += Permutations(a.Length, i);
            }
            int[][] jaggedArray1 = new int[Jarraylenth][];

            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int[] b = { a[i] };

                jaggedArray1 = AllPossibleWays(b, 1, jaggedArray1, c, i + 1, a.Length);
                c++;

            }

            return jaggedArray1;
        }
        public int[][] AllPossibleWays(int[] a, int b, int[][] jaggedArray, int d, int g, int h)
        {
            if (b > 2)
            {
                return jaggedArray;
            }
            if (b == 1)
            {
                int[] c = new int[b];
                c[0] = a[0];
                if (d != 0)
                {
                    while (jaggedArray[d] != null)
                    {
                        d++;
                    }
                }

                jaggedArray[d] = c;
                b++;
                d++;
                return AllPossibleWays(a, b, jaggedArray, d, g, h);
            }
            int JArrayLength = jaggedArray.Length - h;
            int[][] jaggedArray1 = new int[JArrayLength][];
            int f = 0;
            for (int i = 0; i < d; i++)
            {
                if (a[0] == jaggedArray[i][0] && jaggedArray[i].Length == 1)
                {
                }
                else
                {
                    if (!jaggedArray[i].Equals(null))
                    {
                        int vv = jaggedArray[i].Length + 1;
                        int[] c = new int[vv];
                        int e = 0;
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            c[e] = jaggedArray[i][j];
                            e++;
                        }
                        c[e] = a[0];
                        jaggedArray1[f] = c;
                        f++;
                        jaggedArray1[f] = ReverseArray(c);
                        f++;
                        int vc = jaggedArray[i].Length - 1;
                        if (vc > 0)
                        {

                            for (int k = 1; k <= vc; k++)
                            {
                                c = new int[vv];
                                e = 0;
                                for (int j = 0; j < jaggedArray[i].Length; j++)
                                {
                                    if (e == k)
                                    {
                                        c[e] = a[0];
                                        j--;
                                    }
                                    else
                                    {
                                        c[e] = jaggedArray[i][j];
                                    }

                                    e++;
                                }
                                jaggedArray1[f] = c;
                                f++;
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < f; k++)
            {
                if (!jaggedArray1[k].Equals(null))
                {
                    jaggedArray[d] = jaggedArray1[k];
                    d++;
                }
            }
            b++;
            return AllPossibleWays(a, b, jaggedArray, d, g, h);
        }

        public int[] ReverseArray(int[] a)
        {
            int[] b = new int[a.Length];
            int c = 0;
            for (int i = a.Length; i > 0; i--)
            {
                b[c] = a[i - 1];
                c++;
            }
            return b;
        }
        public char[][] AllPossibleWaysExt(char[] a)
        {
            int Jarraylenth = 0;
            for (int i = 1; i <= a.Length; i++)
            {
                Jarraylenth += Permutations(a.Length, i);
            }
            char[][] jaggedArray1 = new char[Jarraylenth][];

            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                char[] b = { a[i] };

                jaggedArray1 = AllPossibleWays(b, 1, jaggedArray1, c, i + 1, a.Length);
                c++;

            }

            return jaggedArray1;
        }
        public char[][] AllPossibleWays(char[] a, int b, char[][] jaggedArray, int d, int g, int h)
        {
            if (b > 2)
            {
                return jaggedArray;
            }
            if (b == 1)
            {
                char[] c = new char[b];
                c[0] = a[0];
                if (d != 0)
                {
                    while (jaggedArray[d] != null)
                    {
                        d++;
                    }
                }

                jaggedArray[d] = c;
                b++;
                d++;
                return AllPossibleWays(a, b, jaggedArray, d, g, h);
            }
            int JArrayLength = jaggedArray.Length - h;
            char[][] jaggedArray1 = new char[JArrayLength][];
            int f = 0;
            for (int i = 0; i < d; i++)
            {
                if (a[0] == jaggedArray[i][0] && jaggedArray[i].Length == 1)
                {
                }
                else
                {
                    if (!jaggedArray[i].Equals(null))
                    {
                        int vv = jaggedArray[i].Length + 1;
                        char[] c = new char[vv];
                        int e = 0;
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            c[e] = jaggedArray[i][j];
                            e++;
                        }
                        c[e] = a[0];
                        jaggedArray1[f] = c;
                        f++;
                        jaggedArray1[f] = ReverseArray(c);
                        f++;
                        int vc = jaggedArray[i].Length - 1;
                        if (vc > 0)
                        {

                            for (int k = 1; k <= vc; k++)
                            {
                                c = new char[vv];
                                e = 0;
                                for (int j = 0; j < jaggedArray[i].Length; j++)
                                {
                                    if (e == k)
                                    {
                                        c[e] = a[0];
                                        j--;
                                    }
                                    else
                                    {
                                        c[e] = jaggedArray[i][j];
                                    }

                                    e++;
                                }
                                jaggedArray1[f] = c;
                                f++;
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < f; k++)
            {
                if (!jaggedArray1[k].Equals(null))
                {
                    jaggedArray[d] = jaggedArray1[k];
                    d++;
                }
            }
            b++;
            return AllPossibleWays(a, b, jaggedArray, d, g, h);
        }
        public char[] ReverseArray(char[] a)
        {
            char[] b = new char[a.Length];
            int c = 0;
            for (int i = a.Length; i > 0; i--)
            {
                b[c] = a[i - 1];
                c++;
            }
            return b;
        }
    }
}
