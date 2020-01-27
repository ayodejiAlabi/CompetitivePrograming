using System;
using System.Collections.Generic;

namespace CodilityTest
{
    public class Algorithm
    {
        public Algorithm()
        {
        }
        public bool BinarySearch(int[] a, int b)
        {
            int low = 0;
            int high = a.Length - 1;
            while (low <= high)
            {
                int mid = Math.Abs((low + high) / 2);
                int guess = a[mid];
                if (guess == b)
                {
                    return true;
                }
                if (guess > b)
                {
                    high -= 1;
                }
                if (guess < b)
                {
                    low += 1;
                }
            }
            return false;
        }

        //Euclid Algorthim for HCF
        public int euclidhcf(int a, int b)
        {
            int c = a % b;
            if (c == 0)
            {
                return a / b;
            }
            return euclidhcf(b, c);
        }
        public int[] QuickSort(int[] a)
        {
            if (a.Length < 1)
            {
                return a;
            }
            int b = Math.Abs(a.Length / 2);
            int pivot = a[b];
            int[] c = new int[a.Length];
            int[] d = new int[a.Length];
            int e = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[0])
                {
                    c[e] = a[i];
                    e++;
                }
            }

            e = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[0])
                {
                    d[e] = a[i];
                    e++;
                }
            }
            return QuickSort(a);
        }
        public int ReservoirSampling(int[] a)
        {
            int b = 0;
            int biggest = 0;
            int[] c = new int[2];
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == 0)
                    {
                        b += 1;
                        biggest = i;
                        c[0] = i;
                    }
                    else
                    {
                        if (a[biggest] < a[i])
                        {
                            b = 1;
                            c = new int[2];
                            c[0] = i;
                            biggest = i;
                        }
                        else if (a[biggest] == a[i])
                        {
                            if (b >= 2)
                            {
                                int[] d = new int[c.Length];
                                c.CopyTo(d, 0);
                                c = new int[b + 1];
                                d.CopyTo(c, 0);
                                c[c.Length - 1] = i;
                                b++;

                            }
                            else
                            {
                                c[1] = i;
                                b++;
                            }
                        }
                    }

                }
                Random random = new Random();
                int e = random.Next(c.Length);
                b = c[e];
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return b;
        }
        public int[] MergeSort(int[] a)
        {
            if (a.Length <= 1)
            {
                return a;
            }
            int b = Math.Abs(a.Length / 2);
            int[] c = new int[b];
            int[] d = new int[a.Length - b];
            int e = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (i < b)
                {
                    c[e] = a[i];
                    e++;
                }
                if (i == b)
                {
                    e = 0;
                }
                if (i >= b)
                {
                    d[e] = a[i];
                    e++;
                }
            }
            int[] f = MergeSort(c);
            int[] g = MergeSort(d);
            // Merge
            return NewMethod(out b, f, g);
        }

        private static int[] NewMethod(out int b, int[] f, int[] g)
        {
            b = f.Length + g.Length;
            int[] l = new int[b];
            int h = 0, j = 0, k = 0;
            while ((h < f.Length) || (j < g.Length))
            {
                //if both arrays have elements  
                if (h < f.Length && j < g.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (f[h] <= g[j])
                    {
                        l[k] = f[h];
                        h++;
                        k++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        l[k] = g[j];
                        j++;
                        k++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (h < f.Length)
                {
                    l[k] = f[h];
                    h++;
                    k++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (j < g.Length)
                {
                    l[k] = g[j];
                    j++;
                    k++;
                }
            }
            return l;
        }
    }
}
