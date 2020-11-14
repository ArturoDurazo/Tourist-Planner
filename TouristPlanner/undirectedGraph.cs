using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristPlanner
{
    class undirectedGraph
    {
        int MAX_VERTICES = 0;
        int n, e;
        int[,] adj;
        vertex[] vertexList;
        List<int> shortestPath = new List<int>();
        List<int> alternatePath = new List<int>();

        public undirectedGraph()
        {
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            vertexList = new vertex[MAX_VERTICES];
        }

        public void init(int vert)
        {
            MAX_VERTICES = vert;
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            vertexList = new vertex[MAX_VERTICES];
        }

        public int vertex()
        {
            return n;
        }

        public int edge()
        {
            return e;
        }

        public string Display()
        {
            string adjMatrix = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    adjMatrix += adj[i, j] + "    ";
                }
                adjMatrix += "\n";
            }
            return adjMatrix;
        }

        public void insertVertex(String name)
        {
            vertexList[n++] = new vertex(name);
        }

        private int getIndex(String s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].name))
                {
                    return i;
                }
            }
            throw new System.InvalidOperationException("Vertice invalido");
        }

        public bool edgeExists(String s1, String s2)
        {
            return isAdjacent(getIndex(s1), getIndex(s2));
        }

        private bool isAdjacent(int u, int v)
        {
            return (adj[u, v] != 0);
        }

        public void insertEdge(String s1, String s2, int weight)
        {
            int u = getIndex(s1);
            int v = getIndex(s2);

            if (adj[u, v] != 0)
            {
                Console.WriteLine("Edge is already present");
            }
            else
            {
                adj[u, v] = weight;
                adj[v, u] = weight;
                e++;
            }
        }

        public static readonly int NO_PARENT = -1;

        public string dijkstra(int startVertex, int endVertex)
        {
            shortestPath.Clear();
            int[] shortestDistances = new int[MAX_VERTICES];

            bool[] added = new bool[MAX_VERTICES];

            for (int vertexIndex = 0; vertexIndex < MAX_VERTICES;
                                                vertexIndex++)
            {
                shortestDistances[vertexIndex] = int.MaxValue;
                added[vertexIndex] = false;
            }

            shortestDistances[startVertex] = 0;

            int[] parents = new int[MAX_VERTICES];

            parents[startVertex] = NO_PARENT;

            for (int i = 1; i < MAX_VERTICES; i++)
            {
                int nearestVertex = -1;
                int shortestDistance = int.MaxValue;
                for (int vertexIndex = 0;
                        vertexIndex < MAX_VERTICES;
                        vertexIndex++)
                {
                    if (!added[vertexIndex] &&
                        shortestDistances[vertexIndex] <
                        shortestDistance)
                    {
                        nearestVertex = vertexIndex;
                        shortestDistance = shortestDistances[vertexIndex];
                    }
                }

                added[nearestVertex] = true;

                for (int vertexIndex = 0;
                        vertexIndex < MAX_VERTICES;
                        vertexIndex++)
                {
                    int edgeDistance = adj[nearestVertex, vertexIndex];

                    if (edgeDistance > 0
                        && ((shortestDistance + edgeDistance) <
                            shortestDistances[vertexIndex]))
                    {
                        parents[vertexIndex] = nearestVertex;
                        shortestDistances[vertexIndex] = shortestDistance +
                                                        edgeDistance;
                    }
                }
            }

            return printSolution(startVertex, shortestDistances, parents, endVertex);
        }

        public string printSolution(int startVertex,
                                        int[] distances,
                                        int[] parents, int endVertex)
        {
            string route = "";
            int nVertices = distances.Length;
            
            if (endVertex != startVertex)
            {
                route += distances[endVertex] + ",";
                route = printPath(endVertex, parents, route, distances);
            }

            return route;
        }

        public string printPath(int currentVertex,
                                    int[] parents, string route,int[] distances)
        {
            if (currentVertex == NO_PARENT)
            {
                return route;
            }
            route = printPath(parents[currentVertex], parents, route, distances);
            shortestPath.Add(currentVertex);

            route += currentVertex + ","; 

            return route;
        }

        public List<int> findAlternate(int startnode, int endNode)
        {
            alternatePath.Clear();
            bool flag = false;
            bool leftToRight = (startnode < endNode);
            bool[] isVisited = new bool[MAX_VERTICES];
            List<int> pathList = new List<int>();
            pathList.Add(startnode);
            findAlternateUtil(startnode, endNode, isVisited, pathList, ref flag, ref leftToRight);
            if (!flag)
            {
                MessageBox.Show(Resources.StringResources.undirected_noRutaAlterna);
            }
            return pathList;
        }
        public void findAlternateUtil(int s, int d, bool[] isVisited, List<int> localPathList, ref bool flag, ref bool leftToRight)
        {

            if(flag)
            {
                return;
            }

            isVisited[s] = true;

            if (s == d)
            {
                shortestPath.Sort();
                List<int> copy = new List<int>(localPathList);
                copy.Sort();
                if (!copy.SequenceEqual(shortestPath))
                {
                    flag = true;
                }
                isVisited[s] = false;
                return;
            }
            for (int i = 0; i < MAX_VERTICES; i++)
            {
                if (adj[s, i] != 0)
                { 
                    if (!isVisited[i])
                    {
                        localPathList.Add(i);
                        findAlternateUtil(i, d, isVisited, localPathList, ref flag, ref leftToRight);
                        if (flag)
                        {
                            return;
                        }
                        localPathList.RemoveAt(localPathList.Count() - 1);
                    }
                }
            }          
            isVisited[s] = false;
        }
    }
}
