using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AmazonPractice
{
    class Utility
    {
        public bool AllienDictionary()
        {
            bool a = true;
            string b = "worldabcefghijkmnpqstuvxyz";
            string[] c = { "word", "world", "row" };
            char[] d = b.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                char[] e = c[i].ToCharArray();
                int[] f = new int[e.Length];
                for (int j = 0; j < e.Length; j++)
                {
                    f[j] = Array.IndexOf(d, e[j]);
                }
                if (i + 1 < c.Length)
                {
                    char[] g = c[i + 1].ToCharArray();
                    for (int k = 0; k < e.Length; k++)
                    {
                        int h = Array.IndexOf(d, g[k]);
                        if (f[k] > h)
                        {
                            return false;
                        }
                        else
                        {
                            if (e[k] != g[k])
                            {
                                break;
                            }

                        }
                    }
                }


            }


            return a;
        }
        public bool IsPalindrome()
        {

            string s = "A man, a plan, a canal: Panama";
            string my_String = Regex.Replace(s, @"[^0-9a-zA-Z]", "");
            char[] a = my_String.ToCharArray();
            Array.Reverse(a);
            string hhh = null;
            for (int i = 0; i < a.Length; i++)
            {
                hhh += a[i].ToString().ToLower();
            }

            if (my_String.ToLower() == hhh)
            {
                return true;
            }
            return false;
        }
        public string LongestPalindrome()
        {
            string s = "abcaba";
            string b = null;
            bool[,] c = new bool[s.Length, s.Length];
            Hashtable cc = new Hashtable();
            int ccc = 0;
            IList<string> vv = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    c[i, i] = true;
                    ccc = 1;
                    if (!cc.ContainsKey(ccc))
                    {
                        cc.Add(ccc, s.Substring(0, 1));
                    }
                }
                if (i + 1 < s.Length)
                {
                    string e = s.Substring(i, 2);
                    char[] f = e.ToCharArray();
                    Array.Reverse(f);
                    c[i, i + 1] = e == f.ToString() ? true : false;
                    if (e == f.ToString())
                    {
                        if (ccc < 2)
                        {
                            ccc = 2;
                            if (!cc.ContainsKey(ccc))
                            {
                                cc.Add(ccc, e);
                            }
                        }
                    }
                }
            }
            char[] m = s.ToCharArray();
            int h = 0;
            while (h < s.Length)
            {
                int g = h + 2;
                while (g < s.Length)
                {
                    if (m[h] == m[g] && c[h + 1, g - 1])
                    {
                        c[h, g] = true;
                        string pallin = s.Substring(h, (g - h) + 1);
                        if (ccc < pallin.Length)
                        {
                            ccc = pallin.Length;
                            if (!cc.ContainsKey(ccc))
                            {
                                cc.Add(ccc, pallin);
                            }
                        }
                    }
                    g++;
                }
                h++;
            }
            return b;
        }
        public void FirstReoccuring(string input)
        {
            LinkedList<char> outPutList = new LinkedList<char>();
            Char[] inputList = input.ToCharArray();
            foreach (char item in inputList)
            {
                Console.WriteLine(item + " ");
                if (outPutList.Contains(item))
                {
                    //HERE IS SUPPOSED TO BE THE ANSWER
                    Console.Write(item + " ");
                }
                outPutList.Append(item);
            }
        }
        public int BiggestSquare(int[][] a)
        {
            int b = 0;
            int maxitem = Math.Max(a.Length, a[0].Length);
            int[,] c = new int[maxitem, maxitem];
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a[i].Length - 1; j++)
                {
                    if (a[i][j] == 1)
                    {
                        b = b == 0 ? 1 : b;
                    }
                    else
                    {
                        continue;
                    }
                    bool dd = true;
                    int cnt = 1;
                    int column = j;
                    int row = i;
                    int cnter = 0;
                    while (dd)
                    {
                        cnter++;
                        if (i + cnter > a.Length - 1 || j + cnter > a[0].Length - 1)
                        {
                            break;
                        }
                        column = j + cnter;
                        row = i;
                        bool d = false;
                        while (row <= j + cnter && row < a.Length)
                        {
                            if (a[row][column] == 1)
                            {
                                d = true;
                                cnt++;
                            }
                            else
                            {
                                d = false;
                                dd = false;
                                break;
                            }
                            row++;
                        }
                        if (d)
                        {
                            d = false;
                            column = i;
                            row = j + cnter;
                            while (column < row && column < a[0].Length && row < a.Length)
                            {
                                if (a[row][column] == 1)
                                {
                                    d = true;
                                    cnt++;
                                    column++;
                                }
                                else
                                {
                                    d = false;
                                    dd = false;
                                    break;
                                }
                            }
                            if (d)
                            {
                                b = b > cnt ? b : cnt;
                            }
                        }
                    }


                }
            }

            return b;
        }
        public bool BiggestSquareHelper(int[][] a, int i, int j)
        {
            bool b = false;
            int c = a[i][j] + a[i][j + 1] + a[i + 1][j] + a[i + 1][j + 1];
            if (c == 4)
            {
                b = true;
            }
            return b;
        }
        public IList<IList<int>> Algo4Sum()
        {
            int[] a = { 1, 0, -1, 0, -2, 2 };
            int k = 0;
            IList<IList<int>> b = new List<IList<int>>();
            SortedSet<string> bb = new SortedSet<string>();
            int bbc = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                int c = k - a[i];

                int[] d = new int[bbc];
                int e = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] != a[i])
                    {
                        d[e] = a[j];
                        e++;
                    }
                }
                IList<IList<int>> f = Algo3Sum(d, c);
                if (f.Count > 0)
                {
                    foreach (var item in f)
                    {
                        item.Add(a[i]);
                        string ggh = null;
                        int[] mmn = new int[item.Count];
                        int mm = 0;
                        foreach (var itema in item)
                        {
                            mmn[mm] = itema;
                            mm++;
                        }
                        Array.Sort(mmn);
                        for (int ii = 0; ii < mmn.Length; ii++)
                        {
                            ggh += mmn[ii].ToString();
                        }
                        if (!bb.Contains(ggh))
                        {
                            b.Add(item);
                            bb.Add(ggh);
                        }


                    }
                }

            }
            return b;
        }
        public IList<IList<int>> Algo3Sum(int[] a, int k)
        {
            IList<IList<int>> b = new List<IList<int>>();
            SortedSet<string> bb = new SortedSet<string>();
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                int c = i + 1;
                int d = a.Length - 1;
                while (c < d)
                {
                    if (a[i] + a[c] + a[d] == k)
                    {
                        string dd = a[i].ToString() + a[c].ToString() + a[d].ToString();
                        if (!bb.Contains(dd))
                        {
                            IList<int> e = new List<int>
                        {
                            a[i],
                            a[c],
                            a[d]
                        };
                            b.Add(e);
                            bb.Add(dd);
                        }
                        c++;
                        d--;
                    }
                    if (a[i] + a[c] + a[d] > k)
                    {

                        d--;
                    }
                    if (a[i] + a[c] + a[d] < k)
                    {

                        c++;
                    }

                }

            }
            return b;
        }
        public int lps(char[] seq, int i, int j)
        {
            // Base Case 1: If there is only 1 character  
            if (i == j)
            {
                return 1;
            }
            // Base Case 2: If there are only 2 characters and both are same  
            if (seq[i] == seq[j] && i + 1 == j)
            {
                return 2;
            }
            // If the first and last characters match  
            if (seq[i] == seq[j])
            {
                return lps(seq, i + 1, j - 1) + 2;
            }
            // If the first and last characters do not match  
            return Math.Max(lps(seq, i, j - 1), lps(seq, i + 1, j));
        }

        public string PalindromicExt(string a)
        {
            string b = null;
            int bb = 0;
            int c = 1;
            for (int i = 0; i < a.Length; i++)
            {
                string d = a.Substring(i, c + i);
                char[] e = d.ToCharArray();
                Array.Reverse(e);
                if (d == e.ToString())
                {
                    if (d.Length > bb)
                    {
                        b = d;
                        bb = d.Length;
                    }

                }
            }
            return b;
        }
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
            int[] b = new int[a.Length + a[1].Length - 1];
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
            if (a + 1 >= c.Length)
            {
                Newposition.a = a;
                Newposition.b = b + 1;
                return Newposition;
            }
            if (b + 1 >= c[c.Length - 1].Length)
            {
                Newposition.a = a + 1;
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
        public int CodilityHoliday(int[] a)
        {
            int b = 0;
            Graph GX = new Graph(a.Length);
            int[,] AdjMatrix = new int[a.Length, a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a[i])
                {
                    AdjMatrix = GX.AddEdge(i, a[i], 1);
                }
                else
                {
                    AdjMatrix = GX.AddEdge(i, a[i], 2);
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a.Length; k++)
                {
                    if (i == k)
                    {
                        b++;
                    }
                    else if (AdjMatrix[i, k] == 1 && i >= 0 && k <= a.Length - 1)
                    {
                        b++;
                    }

                }
            }
            return b;
        }
        public IList<IList<int>> Sum3(int[] a)
        {
            IList<IList<int>> b = new List<IList<int>>();
            SortedSet<String> set = new SortedSet<String>();
            int[][] c = AllPossibleWaysExtCombination(a);
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != null)
                {
                    if (c[i].Length == 3)
                    {
                        int d = TestRecurssion(c[i], c[i].Length);
                        if (d == 0)
                        {
                            int[] y = MergeSort(c[i]);
                            string z = null;
                            for (int l = 0; l < y.Length; l++)
                            {
                                z += y[l].ToString();
                            }
                            if (!set.Contains(z))
                            {
                                IList<int> e = new List<int>();
                                for (int j = 0; j < c[i].Length; j++)
                                {
                                    e.Add(c[i][j]);
                                }
                                b.Add(e);
                                set.Add(z);
                            }
                        }
                    }
                }

            }
            return b;
        }
        public IList<IList<int>> threeSum(int[] nums)
        {
            int[] a = MergeSort(nums);

            IList<IList<int>> b = new List<IList<int>>();

            for (int i = 0; i < a.Length; i++)
            {
                int j = i + 1;
                int k = a.Length - 1;

                if (i > 0 && a[i] == a[i - 1])
                {
                    continue;
                }

                while (j < k)
                {
                    if (k < a.Length - 1 && a[k] == a[k + 1])
                    {
                        k--;
                        continue;
                    }

                    if (a[i] + a[j] + a[k] > 0)
                    {
                        k--;
                    }
                    else if (a[i] + a[j] + a[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        List<int> l = new List<int>();
                        l.Add(a[i]);
                        l.Add(a[j]);
                        l.Add(a[k]);
                        b.Add(l);
                        j++;
                        k--;
                    }
                }
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

        //public ListNode MergeTwoLists(ListNode A, ListNode B)
        //{
        //    if (A == null) return B;
        //    if (B == null) return A;

        //    if (A.val < B.val)
        //    {
        //        A.next = MergeTwoLists(A.next, B);
        //        return A;
        //    }
        //    else
        //    {
        //        B.next = MergeTwoLists(A, B.next);
        //        return B;
        //    }

        //}
        public static int maxProfit(int[] prices)
        {
            int max_profit = -1;
            // Write the code to solve the problem below
            for (int i = 0; i < prices.Length; i++)
            {

            }
            // Return the maximum profit for the given set of prices
            return max_profit;
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
        public int CombinationCnt(int a, int b)
        {
            if (a == 1)
            {
                return 1;
            }
            int c = CombinationCnt(a - 1, b);
            int d = a + c;
            if (a == b)
            {
                return d;
            }
            a = c + d;
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

