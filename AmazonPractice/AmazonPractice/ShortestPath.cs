using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AmazonPractice
{
    class ShortestPath
    {
        int V;
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
        public void Dijkstras(int[,] a, int src)
        {
            V = a.GetLength(0);
            int[] b = new int[V];
            bool[] c = new bool[V];
            // Parent array to store shortest  
            // path tree  
            int[] parents = new int[V];
            for (int i = 0; i < V; i++)
            {
                b[i] = int.MaxValue;
                c[i] = false;
            }
            //Distance from Source to vertex
            b[src] = 0;
            parents[src] = -1;
            for (int j = 0; j < V - 1; j++)
            {
                int d = MinimumDistance(b, c);
                c[d] = true;
                for (int k = 0; k < V; k++)
                {
                    if (!c[k] && a[d, k] != 0 && b[d] < int.MaxValue && b[d] + a[d, k] < b[k])
                    {
                        parents[k] = d;
                        b[k] = b[d] + a[d, k];

                    }
                }
            }
            PrintSolution(src, b, parents);
        }
        public void PrintSolution(int a, int[] b, int[] c)
        {
            int d = b.Length;
            Console.Write("Vertex\t Distance\tPath");
            //for (int i = 0; i < d; i++)
            //{
            int i = 4;
            if (i != a)
            {
                Console.Write("\n" + a + " -> ");
                Console.Write(i + " \t\t ");
                Console.Write(b[i] + "\t\t");
                PrintPath(i, c);
            }
            // }
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
        public void BreadthFirstSeacrh(int[][] a, int src)
        {
            try
            {
                V = a.GetLength(0);
                bool[] SpSet = new bool[V];
                for (int i = 0; i < V; i++)
                {
                    SpSet[i] = false;
                }
                SpSet[src] = true;
                Queue b = new Queue();
                b.Enqueue(src);
                while (b.Count > 0)
                {
                    int v = Convert.ToInt16(b.Dequeue());
                    Console.WriteLine(v.ToString());
                    for (int i = 0; i < a[v].Length; i++)
                    {
                        if (!SpSet[a[v][i]])
                        {
                            SpSet[a[v][i]] = true;
                            b.Enqueue(a[v][i]);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                //throw;
            }
        }
    }
}
