using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Utility jkl = new Utility();
            var cp = jkl.TruckPackageSpace();
            string co = jkl.CompareString("0", "1");
            Console.WriteLine("Hello World!");
            string a = "{(([])[])[]]}";          
            string[] bracKey2 = new string[] { "{}", "[]", "()" };         
            bool c = true;
            if (a.Count() % 2 != 0)
            {
                //return "NO";
            }
            while (c)
            {
                if (a.Contains("[]") || a.Contains("()") || a.Contains("{}"))
                {

                    foreach (var item in bracKey2)
                    {
                        if (a.Contains(item))
                        {
                            a = a.Replace(item, "");
                        }
                    }
                }
                else
                {
                    c = false;
                }

            }


            //if (string.IsNullOrEmpty(a))
            //{
            //    return "YES";
            //}
            //else
            //{
            //    return "NO";
            //}
            int y = 1;
            //int a = 0;
            //int[] A = new int[] { 4, 2, 1 };
            //int[] B = new int[] { 2, 5, 3, };
            //int F = 2;
            //int cnt = 1;
            //IList<int> Frontend = new List<int>();
            //if (F < 2)
            //{
            //    Frontend = A.ToList();
            //}
            //else
            //{
            //    for (int i = 0; i <= A.Count(); i++)
            //    {
            //        var BB = A;
            //        while (BB.Count() >= F)
            //        {
            //            int cnta = 0;
            //            cnta += A[0];
            //            for (int j = 0; j < F - 1; j++)
            //            {
            //                cnta += BB[cnt];
            //                cnt++;
            //            }
            //            cnt = 1;
            //            BB = BB.Where(z => z != BB[cnt]).ToArray();
            //            Frontend.Add(cnta);
            //        }
            //        A = A.Where(z => z != A[0]).ToArray();
            //    }
            //}

            //int Ba = B.Count() - F;
            //IList<int> Backend = new List<int>();
            //if (Ba < 2)
            //{
            //    Backend = B.ToList();
            //}
            //else
            //{
            //    cnt = 1;
            //    for (int i = 0; i <= B.Count(); i++)
            //    {
            //        var BB = B;
            //        while (BB.Count() >= Ba)
            //        {
            //            int cnta = 0;
            //            cnta += A[0];
            //            for (int j = 0; j < Ba - 1; j++)
            //            {
            //                cnta += BB[cnt];
            //                cnt++;
            //            }
            //            cnt = 1;
            //            BB = BB.Where(z => z != BB[cnt]).ToArray();
            //            Backend.Add(cnta);
            //        }
            //        B = B.Where(z => z != B[0]).ToArray();
            //    }
            //}

            //IList<int> MaxWork = new List<int>();
            //foreach (var item in Frontend)
            //{
            //    foreach (var itemt in Backend)
            //    {
            //        MaxWork.Add(itemt + item);
            //    }
            //}
            //int Maxw = MaxWork.Max();

            int[] Aejkk = new int[] { -1, -2 };
            //int bdg = Math.Abs(A.Sum());
            //int length = A.Max() + bdg;
            //bool a = false;
            //for (int i = 0; i < length + bdg; i++)
            //{
            //    foreach (var item in A)
            //    {
            //        if (i == item)
            //        {
            //            a = false;
            //            break;
            //        }
            //        if (i != item)
            //        {
            //            a = true;
            //        }
            //    }
            //    if (a)
            //    {
            //        break;
            //    }
            //}
        }
    }
}

