using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonPractice
{
    class Graph
    {
        static private int V;
        public int[,] adjMatrix;
        public int[][] adjList;
        public Graph(int a)
        {
            V = a;
            adjMatrix = new int[V, V];
            adjList = new int[V][];
        }

        public int[,] AddEdge(int a, int b, int c)
        {
            adjMatrix[a, b] = c;
            return adjMatrix;
        }
        public int[][] AddEdgeList(int a, int b)
        {
            if (adjList[a] == null)
            {
                int[] c = { b };
                adjList[a] = c;
            }
            else
                if (adjList[a] != null)
            {
                int[] c = new int[adjList[a].Length + 1];
                for (int i = 0; i < adjList[a].Length; i++)
                {
                    c[i] = adjList[a][i];
                }
                c[c.Length - 1] = b;
                adjList[a] = c;
            }

            return adjList;
        }

    }

}
