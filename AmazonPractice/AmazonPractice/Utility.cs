using System;
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
            int[] b = new int[] { 100,180,40,120,10};
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
            a.Add(Array.IndexOf(b,datab.Package1));
            a.Add(Array.IndexOf(b, datab.Package2));
            return a;
        }
        public int getMinimumCostToRepair()
        {
            // WRITE YOUR CODE HERE
            int a = 0;
            List<int> bn = new List<int>();
            int[,] numbers2D = new int[3, 3] { { 1,2,12}, { 3,4,30}, {1,5,8 } };
            for (int i = 0; i < numbers2D.Length; i++)
            {
                for (int l = 0; l < numbers2D.Length/3; l++)
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

    }
    public class PackageDataMgr
    {
        public int Package1 { get; set; }
        public int Package2 { get; set; }
        public int PackageSum { get; set; }
    }
}
