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
            ShortestPath lkl = new ShortestPath();
            int[][] a = new int[][]
{
    new int[] { 9,9,7 },
    new int[] { 9,7,2 },
    new int[] { 6,9,5 },
    new int[] { 9,1,2 }
};
            int [] b = jkl.ContinuousMatrix(a);
            //int b = jkl.BooksAndAgesCodility(a,2);
            int[,] adjacencyMatrix = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                    { 0, 0, 4, 0, 10, 0, 2, 0, 0 },
                                    { 0, 0, 0, 14, 0, 2, 0, 1, 6 },
                                    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                    { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            lkl.Dijkstras(adjacencyMatrix, 0);
            var cp = jkl.TruckPackageSpace();
            string co = jkl.CompareString("0", "1");
            Console.WriteLine("Hello World!");






        }
    }
}

