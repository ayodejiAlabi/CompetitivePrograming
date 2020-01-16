using System;
using System.Collections;

namespace CodilityTest
{
    public class ShortestPath
    {

        private int V = 0;
        public void CreateGraph(int[,] a)
        {


        }
        public void ShortestDistance(int[,] a)
        {
            ///This solution provides either the shortest distance from source or the longest distance from source
            int rowsOrHeight = a.GetLength(0);
            int colsOrWidth = a.GetLength(1);
            double ShortestDist = 0;
            int x1 = 0;
            int y1 = 0;
            for (int i = 0; i < rowsOrHeight; i++)
            {
                int b = a[i, 0];
                int c = a[i, 1];
                double dist = DistanceBtwPoints(0, b, 0, c);
                if (i == 0)
                {
                    ShortestDist = dist;
                    x1 = b;
                    y1 = c;
                }
                else
                if (dist < ShortestDist)
                {
                    ShortestDist = dist;
                    x1 = b;
                    y1 = c;
                }
            }

        }
        public double DistanceBtwPoints(int x1, int x2, int y1, int y2)
        {
            double a = 0;
            int b = x2 - x1;
            int c = y2 - y1;
            int bx = b * b;
            int cy = c * c;
            int bcxy = bx + cy;
            a = Math.Sqrt((double)bcxy);
            return a;
        }
        //This method is used to get the vertex with the smallest distance from the  source
        //that has not been added yet
        public int MinimumDistance(int[] a, bool[] b)
        {
            int c = int.MaxValue;
            int d = -1;
            for (int i = 0; i < V; i++)
            {
                if (!b[i] && a[i] <= c)
                {
                    c = a[i];
                    d = i;
                }
            }
            return d;
        }
        public void dijkstra(int[,] adjMatrix, int src)
        {
            V = adjMatrix.GetLength(0);
            // The output array. dist[i] will hold the shortest distance from src to i
            int[] dist = new int[V];
            // Output array to store the shortest path from source
            int[] ShortestPath = new int[V];
            // sptSet[i] will be true if vertex i is included in shortest path
            // tree or shortest distance from src to i is finalized
            bool[] sptSet = new bool[V];
            // Initialize all distances as 
            // INFINITE and stpSet[] as false 
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }
            // Distance of source vertex 
            // from itself is always 0 
            dist[src] = 0;
            ShortestPath[src] = -1;
            // Find shortest path for all vertices 
            for (int j = src; j < V - 1; j++)
            {
                // Pick the minimum distance vertex from the set of vertices not yet 
                // processed. u is always equal to src in first iteration. 
                int u = MinimumDistance(dist, sptSet);
                // Mark the picked vertex as processed 
                sptSet[u] = true;
                for (int k = src; k < V; k++)
                {
                    // Update dist[v] only if it is not in the sptSet, there is an edge from u
                    // to k, and the total weight of path from src to k through u is smaller
                    // than current value of dist[k] 
                    if (!sptSet[k] && adjMatrix[u, k] != 0 && dist[u] != int.MaxValue && dist[u] + adjMatrix[u, k] < dist[k])
                    {
                        dist[k] = dist[u] + adjMatrix[u, k];
                        ShortestPath[k] = u;

                    }
                }
            }
            PrintDistance(src, dist, ShortestPath);

        }
        public void PrintDistance(int a,int[] b,int[]c)
        {
            int d = b.Length;
            Console.Write("Vertex\t Distance\tPath");
            for (int i = 1; i < d; i++)
            {
                //Comment out the for loop and uncomment the line below to select the destination
                //if you dont want to print all the paths
                //int i = 4;
                if (i != a)
                {
                    Console.Write("\n" + a + " -> ");
                    Console.Write(i + " \t\t ");
                    Console.Write(b[i] + "\t\t");
                    PrintPath(i, c);
                }
            }
        }
        public void PrintPath(int a, int[] b)
        {
            if (a == -1)
            {
                return;
            }
            PrintPath(b[a], b);
            Console.Write(a + " ");
        }
        public void BreadthFirstSeacrh(int[,] a,int src,int destination)
        {
            // breadth first search to transverse an unweighted graph
            try
            {
                V = a.GetLength(0);
                bool[] VisitedSet = new bool[V];
                for (int i = 0; i < VisitedSet.Length; i++)
                {
                    VisitedSet[i] = false;
                }
                Queue b = new Queue();
                /// Set start point as visited
                VisitedSet[src] = true;
                b.Enqueue(src);
                for (int i = 0; i < V; i++)
                {

                }


            }
            catch (Exception ex)
            {
                string errormsg = ex.Message;
            }
        }
    }
}
