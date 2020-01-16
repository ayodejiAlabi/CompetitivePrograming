using System;
using System.Collections.Generic;
using static CodilityTest.Graph;

namespace CodilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            utility jkl = new utility();
            MainUtility okl = new MainUtility();
            DataStructure lkl = new DataStructure();
            ShortestPath pkl = new ShortestPath();
            Combination jjkl = new Combination();
            Algorithm hgt = new Algorithm();
            
            GFG t = new GFG();
          
            //int yy = hgt.euclidhcf(500, 250);
            //int[] yyuy = { 1,2,9,5,7,3};
            //int[] vwfjnv = hgt.QuickSort(yyuy);
            //bool gdgf = hgt.BinarySearch(yyuy, 50);
            //int dhdh = jjkl.CombinationCnt(5,5);
            //int[] mm = { 1,2,3,4,5 };
            //int[][] combi = jjkl.AllPossibleWaysExtCombination(mm);
            //double jjji = pkl.DistanceBtwPoints(3, 7, 2, 8);
            //int[,] aty = {  { 1, 2 }, { 0, 4 }, { 3, 6 }, { 4, 8 } };
            //pkl.ShortestDistance(aty);
            //int ty = okl.Factorial(5);
            //char[] gh = {'A', 'B', 'C' };

            int[][] a =
      {
    new int[] { 3,7,-3,0,1,8 },
    new int[] { 1,-4,-7,-8,-6,5 },
    new int[] { -8,1,3,3,5,7 },
    new int[] { -2,4,3,1,2,7 },
    new int[] { 2,4,-5,1,8,4},
    new int[] { 5,-7,6,5,2,8 }
};
            //int b = okl.HourGlass(a);
            //int[] a = { 100, 180, 40, 120, 10,150,30,90,80 };
            //int [] nnnb = okl.TruckPackageSpace(a,250,30);


            //int[][] jaggedArray = okl.AllPossibleWays(a,1, jaggedArray1,0);
            //int to = okl.TestRecurssionMultiply(a,a.Length);


            //int[] a = { 1, 2 };
            //int b = okl.AllPossibleSumToInt(a, 3);
            //Console.WriteLine(b);
            //int[] LinkedArray = { 27,14,35,10,19,31,42};
            //foreach (var item in LinkedArray)
            //{
            //lkl.AddTreeItem(item);
            //}
            //lkl.Trigger();
            //lkl.DeleteNodeDoubleLinkedList(7);
            //lkl.CountLinkedList();
            //lkl.PrintAllNodes();
            //lkl.DeleteNode(3);
            //lkl.CountLinkedList();
            //lkl.PrintAllNodes();
            /* Let us create the example 
graph discussed above */
            int[,] graph = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                    { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            //t.dijkstra(graph, 0);
            //lkl.Graph(4);
            //IList<string> nodes = new List<string>();
            //nodes.Add("A");
            //nodes.Add("B");
            //nodes.Add("C");
            //nodes.Add("D");

            //lkl.AddGNode(nodes);

            //lkl.AddEdge(1, 2, 2500);
            //lkl.AddEdge(1, 3, 3000);
            //lkl.AddEdge(1, 4, 7000);
            //lkl.AddEdge(2, 4, 3000);
            //lkl.AddEdge(3, 4, 2000);

            //lkl.Display();
            int[] bg = { 11, 30, 2, 30, 30, 30, 6, 2, 62, 62 };
            int[] bv = hgt.MergeSort(bg);
            //int bv = hgt.ReservoirSampling(bg);
        }

    }
}
