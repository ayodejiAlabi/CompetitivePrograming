using System;
namespace CodilityTest
{
    public class Combination
    {
        public int CombinationCnt(int a,int b)
        {
            if (a == 1)
            {
             return 1;
            }
            int c = CombinationCnt(a - 1,b);
            int d = a + c;
           if (a == b)
            {
              return d;
            }
            a = c +d;
            return a;
        }
        public int[][] AllPossibleWaysExtCombination(int[] a)
        {
            int Jarraylenth = CombinationCnt(a.Length, a.Length);

            int[][] jaggedArray1 = new int[Jarraylenth][];

            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int[] b = { a[i] };

                jaggedArray1 = AllPossibleWaysCombination(b, 1, jaggedArray1, c, i + 1, a.Length);
                c++;

            }

            return jaggedArray1;
        }

        public int[][] AllPossibleWaysCombination(int[] a, int b, int[][] jaggedArray, int d, int g, int h)
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
                return AllPossibleWaysCombination(a, b, jaggedArray, d, g, h);
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
            return AllPossibleWaysCombination(a, b, jaggedArray, d, g, h);
        }
    }
}
