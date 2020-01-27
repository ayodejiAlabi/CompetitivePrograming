using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AmazonPractice
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Utility jkl = new Utility();
            ShortestPath lkl = new ShortestPath();
            //jkl.Algo4Sum();
            jkl.AllienDictionary();
            jkl.IsPalindrome();
            jkl.LongestPalindrome();
            int[][] a = new int[][]
{

    new int[]  { 1,1},
    new int[]  { 0,1},
  

};
            int aa = jkl.BiggestSquare(a);
            int[] b = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> bgh = jkl.Sum3(b);
            int bb = jkl.CodilityHoliday(b);
            // int [] b = jkl.ContinuousMatrix(a);
            //int b = jkl.BooksAndAgesCodility(a,2);
            //int[,] adjacencyMatrix = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            //                        { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            //                        { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            //                        { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            //                        { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            //                        { 0, 0, 4, 0, 10, 0, 2, 0, 0 },
            //                        { 0, 0, 0, 14, 0, 2, 0, 1, 6 },
            //                        { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            //                        { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            Graph Adj = new Graph(4);
            Adj.AddEdgeList(0, 1);
            Adj.AddEdgeList(0, 2);
            Adj.AddEdgeList(1, 2);
            Adj.AddEdgeList(2, 0);
            Adj.AddEdgeList(2, 3);
            int[][] adjacencyList = Adj.AddEdgeList(3, 3);
            lkl.BreadthFirstSeacrh(adjacencyList, 2);
            //lkl.Dijkstras(adjacencyMatrix, 0);
            var cp = jkl.TruckPackageSpace();
            string co = jkl.CompareString("0", "1");
            Console.WriteLine("Hello World!");






        }
    }
}

