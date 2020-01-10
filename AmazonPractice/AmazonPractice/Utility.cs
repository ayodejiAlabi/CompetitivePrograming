using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonPractice
{
    class Utility
    {
        public string Palindromic(string a)
        {
            //Find the longest palindromic substring  from the given string. No need of DP solution.
            string b = null;
            IList<string> Palin = new List<string>();
            string Palindromic = a;
            int c = Palindromic.Length;
            int kk = 2;
            int cc = 1;
            for (int j = 0; j < c + 1; j++)
            {
                for (int k = kk; k < c + cc; k++)
                {
                    string ac = Palindromic.Substring(j, k);
                    char[] charArray = ac.ToCharArray();
                    Array.Reverse(charArray);
                    string bb = new string(charArray);
                    if (ac.Trim() == bb.Trim())
                    {
                        Palin.Add(ac);
                    }
                }
                cc--;
            }
            string longest = Palin.OrderByDescending(s => s.Length).First();
            return b;
        }
        public string BalancingBracket(string s)
        {
            //string a = "{(([])[])[]]}";
            string a = s;
            string[] bracKey2 = new string[] { "{}", "[]", "()" };
            bool c = true;
            if (a.Count() % 2 != 0)
            {
                return "NO";
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
            if (string.IsNullOrEmpty(a))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        public string CompareString(string a, string b)
        {
            string d = "0123456789";
            if (a.Length > b.Length)
            {
                return a;
            }
            else if (b.Length > a.Length)
            {
                return b;
            }
            else
            {
                if (a.Trim() == b.Trim())
                {
                    return "Equal";
                }
                string e = a.Substring(0, 1);
                int f = d.IndexOf(e);
                d = d.Substring(0, f);
                if (d.Contains(b.Substring(0, 1)))
                {
                    return a;
                }
                else
                {
                    return b;
                }

            }

        }
        public int LongestSubstring()
        {
            int a = 0;
            string[] y = new string[] { "xxbxxyyyrr", "xbxbbbbyyyrb", "xbbbbyyyyyb", "bbbyyyyxb" };

            IList<int> cnt = new List<int>();
            IList<string> c = new List<string>();
            int cntx = 1;
            //0(n2)
            while (cntx < y.Count())
            {
                var b = Enumerable.Range(1, y.Length).Select(i => y[i % y.Length]).ToArray();
                for (int i = 0; i < b.Count(); i++)
                {
                    string e = b[i];
                    string[] d;
                    d = b.Where(z => z.Trim().ToLower() != b[i].Trim().ToLower()).ToArray();
                    foreach (var item in d)
                    {
                        e += item;
                    }
                    c.Add(e);
                }
                y = b;
                cntx++;
            }

            foreach (var item in c)
            {
                string p = null;
                for (int i = 0; i < item.Length - 1; i++)
                {
                    string m = item.Substring(i, 1);
                    string l = item.Substring(i + 1, 1);
                    if (m.Trim().ToLower() == l.Trim().ToLower())
                    {
                        p += m;

                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(p))
                        {
                            cnt.Add(p.Count());
                            p = m;
                        }

                    }
                }

            }
            a = cnt.Max();
            return a;
        }
        public int[] reverseArray(int[] a)
        {
            IList<int> b = new List<int>();
            for (int i = a.Count() - 1; i >= 0; i--)
            {
                b.Add(a[i]);
            }
            return b.ToArray();
        }
        public int[] Houses(int b)
        {
            int[] c = new[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            //01001010
            for (int j = 0; j < b; j++)
            {
                IList<int> d = new List<int>();
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == 0)
                    {
                        int ff = 0 + c[i + 1];
                        d.Add(ff);

                    }
                    else if (i == c.Length - 1)
                    {
                        int ff = 0 + c[i - 1];
                        d.Add(ff);

                    }
                    else
                    {
                        int ff = c[i - 1] + c[i + 1];
                        d.Add(ff);

                    }

                }
                c = d.ToArray();
            }
            return c;

        }
        public int HCM()
        {
            int a = 0;
            int cnt = 1;
            int[] b = new int[] { 2, 4, 6, 8, 10 };
            int ddf = b.Max();
            IList<int> c = new List<int>();
            while (cnt < b.Max())
            {
                int d = 0;
                foreach (var item in b)
                {
                    d += item % cnt;
                }
                if (d == 0)
                {
                    c.Add(cnt);
                }
                cnt++;
            }

            return c.Max();

        }
        public IList<int> TruckPackageSpace()
        {
            List<int> a = new List<int>();
            int u = a.Count();
            List<PackageDataMgr> datamgr = new List<PackageDataMgr>();
            int[] b = new int[] { 100, 180, 40, 120, 10 };
            int TruckSpace = 250;
            int SafetyNet = 30;
            for (int i = 0; i < b.Length; i++)
            {
                foreach (var item in b)
                {
                    if (item != b[i])
                    {
                        int c = b[i] + item + SafetyNet;
                        if (c <= TruckSpace)
                        {
                            PackageDataMgr data = new PackageDataMgr();
                            data.PackageSum = c;
                            data.Package1 = b[i];
                            data.Package2 = item;
                            datamgr.Add(data);
                        }
                    }
                }
            }

            int kk = datamgr.Max(c => c.PackageSum);
            PackageDataMgr datab = datamgr.Where(x => x.PackageSum == kk).FirstOrDefault();
            a.FindIndex(n => n == datab.Package1);
            a.Add(Array.IndexOf(b, datab.Package1));
            a.Add(Array.IndexOf(b, datab.Package2));
            return a;
        }
        public int getMinimumCostToRepair()
        {
            // WRITE YOUR CODE HERE
            int a = 0;
            List<int> bn = new List<int>();
            int[,] numbers2D = new int[3, 3] { { 1, 2, 12 }, { 3, 4, 30 }, { 1, 5, 8 } };
            for (int i = 0; i < numbers2D.Length; i++)
            {
                for (int l = 0; l < numbers2D.Length / 3; l++)
                {
                    int cv = numbers2D[i, 0];
                    int cv1 = numbers2D[i, 1];
                    int cv2 = numbers2D[i, 2];
                    int cv3 = numbers2D[i + 1, 0];
                    int cv4 = numbers2D[i + 1, 1];
                    int cv5 = numbers2D[i + 1, 2];
                    int cv6 = cv2 + cv5;
                    bn.Add(cv6);
                }

            }
            return a;
        }

        public int BooksAndAgesCodility(int[] a, int b)
        {
            int c = 0;
            int chk = 0;
            c = MaxContinuousArray(a);
            if (b == 0)
            {
                return c;
            }
            chk = c;
            int[][] d = NumberOfItemsExist(a);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != null)
                {
                    if (d[i][1] == chk)
                    {
                        int[] e = new int[a.Length];
                        a.CopyTo(e, 0);
                        int z = b;
                        if (d[i][2] != 0)
                        {
                            if (d[i][2] + b - 1 < a.Length)
                            {
                                bool aa = true;
                                for (int jj = 0; jj < b; jj++)
                                {
                                    if (e[d[i][2] + jj] == d[i][0])
                                    {
                                        aa = false;
                                    }
                                }
                                if (aa)
                                {
                                    for (int j = 0; j < b; j++)
                                    {
                                        if (d[i][2] + j < a.Length - z)
                                        {
                                            e[d[i][2] + j] = d[i][0];
                                            z--;
                                        }
                                    }
                                    int f = MaxContinuousArray(e);
                                    if (f > c)
                                    {
                                        c = f;
                                    }
                                }
                            }
                        }
                        e = new int[a.Length];
                        a.CopyTo(e, 0);
                        z = b;
                        int y = d[i][2] - d[i][1];
                        y -= 1;
                        if (y >= b)
                        {
                            bool aa = true;
                            for (int jj = 0; jj < b; jj++)
                            {
                                if (e[y - jj] == d[i][0])
                                {
                                    aa = false;
                                }
                            }
                            if (aa)
                            {
                                for (int j = 0; j < b; j++)
                                {
                                    e[y - j] = d[i][0];
                                }
                                int f = MaxContinuousArray(e);
                                if (f > c)
                                {
                                    c = f;
                                }
                            }

                        }
                        if (d[i][2] != 0)
                        {
                            if (b == 2)
                            {
                                e = new int[a.Length];
                                a.CopyTo(e, 0);
                                if (d[i][2] - (d[i][1] + 1) >= 0)
                                {
                                    if (e[d[i][2]] != d[i][0] && e[d[i][2] - (d[i][1] + 1)] != d[i][0])
                                    {
                                        e[d[i][2]] = d[i][0];
                                        e[d[i][2] - (d[i][1] + 1)] = d[i][0];
                                    }
                                    int f = MaxContinuousArray(e);
                                    if (f > c)
                                    {
                                        c = f;
                                    }
                                }
                            }
                            if (b > 2)
                            {
                                int zz = b - 1;
                                int yy = 1;
                                e = new int[a.Length];
                                a.CopyTo(e, 0);
                                for (int q = 0; q < b; q++)
                                {
                                    if ((d[i][2] + zz - 1 < a.Length) && (d[i][2] - ((d[i][1] - 1) + yy) >= 0))
                                    {
                                        zz--;
                                        yy++;
                                        bool aa = true;
                                        for (int jj = 0; jj < zz; jj++)
                                        {
                                            if (e[d[i][2] + jj] == d[i][0])
                                            {
                                                aa = false;
                                            }
                                        }
                                        y = d[i][2] - (d[i][1] - 1);
                                        for (int jj = 0; jj < b; jj++)
                                        {
                                            if (e[y - jj] == d[i][0])
                                            {
                                                aa = false;
                                            }
                                        }
                                        if (aa)
                                        {
                                            for (int j = 0; j < b; j++)
                                            {
                                                e[y - j] = d[i][0];
                                                e[d[i][2] + j] = d[i][0];
                                            }
                                        }
                                        int f = MaxContinuousArray(e);
                                        if (f > c)
                                        {
                                            c = f;
                                        }
                                    }
                                }



                            }
                        }


                    }
                }

            }

            return c;
        }
        public int[][] NumberOfItemsExist(int[] a)
        {
            int[] b = a.Distinct().ToArray();
            int[][] d = new int[a.Length][];
            int m = 0;
            for (int i = 0; i < b.Length; i++)
            {
                int e = 0;
                for (int j = 0; j < a.Length; j++)
                {

                    if (b[i] == a[j])
                    {
                        e++;
                    }
                    else
                    {
                        if (e > 0)
                        {
                            int[] f = new int[3];
                            f[0] = b[i];
                            f[1] = e;
                            f[2] = j;
                            d[m] = f;
                            m++;
                            e = 0;
                        }

                    }
                    if (j == a.Length - 1)
                    {
                        if (e > 0)
                        {
                            int[] f = new int[3];
                            f[0] = b[i];
                            f[1] = e;
                            f[2] = 0;
                            d[m] = f;
                            m++;
                            e = 0;
                        }
                    }
                }

            }
            return d;
        }
        public int[] RemoveItem(int[] a, int b)
        {
            int[] c = new int[a.Length - 1];
            for (int i = 0; i < c.Length; i++)
            {
                if (a[i] != b)
                {
                    c[i] = a[i];
                }
                else
                {
                    i--;
                }
            }
            return c;
        }
        public int MaxContinuousArray(int[] a)
        {
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        c++;
                    }
                    else
                    {
                        if (c > b)
                        {
                            b = c;
                        }
                        c = 0;
                    }
                }
                if (c > b)
                {
                    b = c;
                }
            }
            return b;
        }

        public int[] ContinuousMatrix(int[][] a)
        {
            int[] b = new int[a.Length + a[1].Length-1];
            int c = 0;
            b[c] = a[0][0];
            c++;
            int d = 0;
            int e = 0;
            for (int i = 0; i < b.Length; i++)
            {
                Positions NewPositions = GetMaximumClosetoit(d, e, a);
                b[c] = a[NewPositions.a][NewPositions.b];
                c++;
                d = NewPositions.a;
                e = NewPositions.b;
                if (d >= a.Length - 1 && e >= a[a.Length - 1].Length - 1)
                {
                    break;
                }
            }

            return b;
        }
        public Positions GetMaximumClosetoit(int a, int b, int[][] c)
        {
            int e = c[a].Length;
            Positions Newposition = new Positions();
            if (a >= c.Length - 1 && b >= c[c.Length - 1].Length - 1)
            {
                Newposition.a = a;
                Newposition.b = b;
                return Newposition;
            }
            if (a+1 >= c.Length)
            {
                Newposition.a = a;
                Newposition.b = b+1;
                return Newposition;
            }
            if (b+1 >= c[c.Length - 1].Length)
            {
                Newposition.a = a+1;
                Newposition.b = b;
                return Newposition;
            }
            if (c[a][b + 1] > c[a + 1][b])
            {
                Newposition.a = a;
                Newposition.b = b + 1;
            }
            else if (c[a][b + 1] < c[a + 1][b])
            {
                Newposition.a = a + 1;
                Newposition.b = b;
            }
            else
            {
                Positions Newpositionu = GetMaximumClosetoit(a, b + 1, c);
                Positions Newpositionh = GetMaximumClosetoit(a + 1, b, c);
                if (c[Newpositionu.a][Newpositionu.b] > c[Newpositionh.a][Newpositionh.b])
                {
                    Newposition.a = a;
                    Newposition.a = b + 1;
                }
                if (c[Newpositionu.a][Newpositionu.b] < c[Newpositionh.a][Newpositionh.b])
                {
                    Newposition.a = a + 1;
                    Newposition.a = b;
                }

            }
            return Newposition;
        }
    }


    public class PackageDataMgr
    {
        public int Package1 { get; set; }
        public int Package2 { get; set; }
        public int PackageSum { get; set; }
    }
    public class Positions
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}
