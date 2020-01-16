using System;
using System.Collections.Generic;
namespace CodilityTest
{
    public class utility
    {
        public utility()
        {
        }
        public int EqualValuesMatrix(int [][] A)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                foreach (int[] array in A)
                {
                    Console.WriteLine("Starting new array");
                    b = array.Length;
                    foreach (int item in array)
                    {
                        c += item;
                    }
                    if (c == b || c == 0)
                    {
                        a++;
                    }
                    c = 0;

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            
            return a;
        }
        public int FlipMatrixComplete(int[][] A)
        {
            int a = 0;
            try
            {
                int b = A.Length;
                IList<int> c = new List<int>();
                //c.Add(EqualValuesMatrix(A));
                //for (int i = 1; i <= b; i++)
                //{
                    //c.Add(FlipMatrix1(A, i));
                //}
                for (int i = 0; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    c.Add(EqualValuesMatrix(C));
                }
                for (int i = 0; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                 }
                for (int i = 1; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    c.Add(EqualValuesMatrix(C));
                }
                for (int i = 1; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                }
                for (int i = 2; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    c.Add(EqualValuesMatrix(C));
                }
                for (int i = 2; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                }
                for (int i = 3; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    c.Add(EqualValuesMatrix(C));
                }
                for (int i = 3; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                }
                for (int i = 4; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    c.Add(EqualValuesMatrix(C));
                }
                for (int i = 4; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return a;
        }
        public IList<int> FlipMatrix(int [][] A)
        {
            IList<int> b = new List<int>();
            try
            {
                b.Add(EqualValuesMatrix(A));
                for (int i = 0; i <= A.Length; i++)
                {
                    int[][] C = Flip(A, i);
                    b.Add(EqualValuesMatrix(C));
                }
                int[][] D = A;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
          
            return b;
        }
        public int FlipMatrix1(int[][] A,int B)
        {
            int a = 0;
            try
            {
                int[][] C = Flip(A, B);
                a = EqualValuesMatrix(C);
                C = Flip(A, B);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return a;
        }
        public int [][] Flip(int[][]A,int B)
        {
            try
            {
                foreach (var item in A)
                {
                    item[B] = (item[B] == 0) ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return A;
        }

    }
}
