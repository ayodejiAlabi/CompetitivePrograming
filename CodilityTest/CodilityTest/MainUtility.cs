using System;
using System.Collections;
using System.Collections.Generic;
namespace CodilityTest
{
    public class MainUtility
    {
        public MainUtility()
        {
        }
        public int TestRecurssion(int[] a, int b)
        {
            if (b <= 0)
            {
                return 0;
            }
            int c = a[b - 1];
            int d = c + TestRecurssion(a, b - 1);
            return d;

        }
        public int TestRecurssionMultiply(int[] a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            int c = a[b - 1];
            int d = c * TestRecurssionMultiply(a, b - 1);
            return d;

        }

        public int Factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            if (a == 2)
            {
                return 2;
            }
            return a * Factorial(a - 1);
        }
        public int AllPossibleSumToInt(int[] A, int b)
        {
            int c = 0;
            if (b.Equals(0))
            {
                return 1;
            }
            int[] d = new int[b + 1];
            d[0] = 1;
            for (int i = 1; i <= b; i++)
            {
                c = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (i - A[j] >= 0)
                    {
                        c += d[i - A[j]];
                    }
                }
                d[i] = c;
            }
            return d[b];
        }
        //Amazon online coding question on truck package space
        public int[] TruckPackageSpace(int[] a,int TruckSpace,int SafetyNet)
        {
            Combination jjkl = new Combination();
            int[][] b = jjkl.AllPossibleWaysExtCombination(a);
            int c = 0;
            int d = 0;
            for (int i = 0; i < b.Length; i++)
            {
                int e = TestRecurssion(b[i], b[i].Length);
                e += SafetyNet;
                if (e <= TruckSpace)
                {
                    if (i == 0)
                    {
                        c = i;
                        d = e;
                    }
                    else
                    {
                        if (e > d)
                        {
                            c = i;
                            d = e;
                        }
                    }
                 
                }
            }
            return b[c];
        }
        //Hackerrank Question
        public int HourGlass(int[][] a)
        {
            int b = 0;
            int[] c = new int[a.Length * a[1].Length];
            int d = 0;
            int h = 4;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    c[d] = a[i][j];
                    d++;
                }
            }
            for (int k = 0; k < c.Length-14; k++)
            {
                int[] e = new int[7];
                int f = 0;
                if (k== h)
                {
                    k += 2;
                    h += 6;
                }
                for (int l = k; l < k+3; l++)
                {
                    e[f] = c[l];
                    f++;
                }
                e[f] = c[k + 7];
                f++;
                for (int l = k+12; l < k + 15; l++)
                {
                    e[f] = c[l];
                    f++;
                }
                int g = TestRecurssion(e, e.Length);
                if (g == 34)
                {

                }
                if (k == 0)
                {
                    b = g;
                }
                else
                {
                    if (g>b)
                    {
                        b = g;
                    }
                }
            }

            return b;
        }

        public int ConsecutiveItem(int[] a,int b)
        {
            int c = 0;
            int d = 0;
            for (int i = 0; i < a.Length; i++)
            {
              if (b == a[i])
                {
                    c++;
                }
                else
                {
                    if (c > d)
                    {
                        d = c;
                        c = 0;
                    }
                 }
            }

            return (d > c) ? d : c ;
        }
        public int BooksAndAgesCodility(int[] a, int b)
        {
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i]!= a[j])
                    {

                    }
                }
            }

            return c;
        }

    }
}
