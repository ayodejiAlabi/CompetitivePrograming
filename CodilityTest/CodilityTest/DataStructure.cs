using System;
using System.Collections.Generic;
using static CodilityTest.Graph;

namespace CodilityTest
{
    public class DataStructure
    {
        public class Node
        {
            public object Data;
            public Node Next;
            public Node Prev;
        }
        private Node head;

        public void AddLinkedListItem(object data)
        {
            try
            {
                if (head == null)
                {
                    head = new Node();
                    head.Data = data;
                    head.Next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.Data = data;
                    toAdd.Next = null;
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = toAdd;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public void CountLinkedList()
        {
            int a = 0;
            Node current = head;
            while (current != null)
            {
                a++;
                current = current.Next;
            }
            Console.WriteLine(a);
        }
        public void DeleteNode(object data)
        {
            try
            {
                Node current = head;
                if (current.Data.Equals(data))
                {
                    head = current.Next;
                }
                else
                {
                    while (current != null)
                    {
                        if (current.Next.Next == null)
                        {
                            current.Next = null;
                            break;

                        }
                        if (current.Next.Data.Equals(data))
                        {

                            current.Next = current.Next.Next;
                            break;
                        }
                        current = current.Next;
                    }
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void AddDoubleLinkedListItem(object data)
        {
            try
            {
                if (head == null)
                {
                    head = new Node();
                    head.Data = data;
                    head.Next = null;
                    head.Prev = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.Data = data;
                    toAdd.Next = null;
                    toAdd.Prev = null;
                    Node current = head;
                    Node Prev = head;
                    while (current.Next != null)
                    {
                        Prev = current;
                        current = current.Next;
                    }
                    current.Next = toAdd;
                    current.Prev = Prev;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void DeleteNodeDoubleLinkedList(object data)
        {
            try
            {
                Node current = head;
                if (current.Data.Equals(data))
                {
                    head = current.Next;
                }
                else
                {
                    while (current != null)
                    {
                        if (current.Next.Data.Equals(data))
                        {
                            if (current.Next.Next == null)
                            {
                                current.Next = null;
                                break;

                            }
                            current.Next = current.Next.Next;
                            current.Next.Next.Prev = current.Next;
                            break;
                        }
                        current = current.Next;
                    }
                }


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public class TreeNode
        {
            public int Data;
            public TreeNode LeftChild;
            public TreeNode RightChild;
        }
        private TreeNode root;
        public void AddTreeItem(int data)
        {
            try
            {
                TreeNode TempData = new TreeNode();
                TreeNode Current;
                TreeNode Parent;
                TempData.Data = data;
                //if tree is empty create root
                if (root == null)
                {
                    root = TempData;
                }
                else
                {
                    Current = root;
                    Parent = null;
                    while (true)
                    {
                        Parent = Current;
                        //go to the left of the tree
                        if (data < Parent.Data)
                        {
                            Current = Current.LeftChild;
                            //Insert to the left
                            if (Current == null)
                            {
                                Parent.LeftChild = TempData;
                                break;
                            }
                        }
                        //go to the right of the tree
                        else
                        {
                            Current = Current.RightChild;
                            if (Current == null)
                            {
                                Parent.RightChild = TempData;
                                break;
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

        }
        public bool SearchTree(int data)
        {
            bool a = false;
            try
            {
                TreeNode Current;
                Current = root;
                if (data == Current.Data)
                {
                    return true;
                }
                if (data != Current.Data)
                {
                    while (Current != null)
                    {
                        if (data < Current.Data)
                        {
                            Current = Current.LeftChild;

                        }
                        if (Current != null)
                        {
                            if (data > Current.Data)
                            {
                                Current = Current.RightChild;
                            }

                            if (data == Current.Data)
                            {
                                return true;

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return a;
        }
        public void PreOrderTransversal(TreeNode Current)
        {
            try
            {
                if (Current != null)
                {
                    Console.WriteLine(Current.Data);
                    PreOrderTransversal(Current.LeftChild);
                    PreOrderTransversal(Current.RightChild);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void InOrderTransversal(TreeNode Current)
        {
            try
            {
                if (Current != null)
                {
                    InOrderTransversal(Current.LeftChild);
                    Console.WriteLine(Current.Data);
                    InOrderTransversal(Current.RightChild);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void PostOrderTransversal(TreeNode Current)
        {
            try
            {
                if (Current != null)
                {
                    PostOrderTransversal(Current.LeftChild);
                    PostOrderTransversal(Current.RightChild);
                    Console.WriteLine(Current.Data);

                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
        public void Trigger()
        {
            InOrderTransversal(root);
        }
        public class GraphNode
        {
            public int index;
            public string data;

        }
        /// <summary>
        /// 3 attributes
        /// A list of vertices (to store node information for each index such as name/text)
        /// a 2D array - our adjacency matrix, stores edges between vertices
        /// a graphSize integer
        /// a StreamReader, to read in graph data to create the data structure
        /// </summary>
        private List<GraphNode> vertices;
        private int graphSize;
        private int[,] adjMatrix;
        public void Graph(int V)
        {
            vertices = new List<GraphNode>();
            CreateGraph(V);
        }
        private void CreateGraph(int SizeOfGraph)
        {
            //get the graph size first
            graphSize = SizeOfGraph + 1;//non-zero arrays, add 1
            adjMatrix = new int[graphSize, graphSize];
            //ASSUME ALL DATA HAS BEEN READ FROM A TEXT FILE & ADJACENCY MATRIX HAS BEEN INITIALIZED
        }
        public void AddGNode(IList<string> Nodes)
        {
            int y = 0;
            foreach (var item in Nodes)
            {
                y++;
                GraphNode nm = new GraphNode();
                nm.index = y;
                nm.data = item;
                vertices.Add(nm);
            }
        }
        public void AddEdge(int vertexA, int vertexB, int distance)
        {
            if (vertexA > 0 && vertexB > 0 && vertexA <= graphSize && vertexB <= graphSize)
            {
                adjMatrix[vertexA, vertexB] = distance;
            }
        }
        public void RemoveEdge(int vertexA, int vertexB)
        {
            if (vertexA > 0 && vertexB > 0 && vertexA <= graphSize && vertexB <= graphSize)
            {
                adjMatrix[vertexA, vertexB] = 0;
            }
        }
        public bool Adjacent(int vertexA, int vertexB)
        {   //checks whether two vertices are adjacent, returns true or false
            return (adjMatrix[vertexA, vertexB] > 0);
        }
        public int length(int vertex_u, int vertex_v)//returns a distance between 2 nodes
        {
            return adjMatrix[vertex_u, vertex_v];
        }
        public void Display() //displays the adjacency matrix
        {
            GFG t = new GFG();
            ShortestPath pkl = new ShortestPath();
            pkl.dijkstra(adjMatrix, 1);
            Console.WriteLine("***********Adjacency Matrix Representation***********");
            Console.WriteLine("Number of nodes: {0}\n", graphSize - 1);
            foreach (GraphNode n in vertices)
            {
                Console.Write(n.data);
            }
            Console.WriteLine();//newline for the graph display
            for (int i = 1; i < graphSize; i++)
            {

            }
            Console.WriteLine("Read the graph from left to right");
            Console.WriteLine("Example: Node A has an edge to Node C with distance: {0}",
                length(1, 3));

        }
    }


}
