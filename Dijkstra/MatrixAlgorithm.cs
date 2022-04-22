using System;

namespace DijkstraAlgorithmOnGraph
{
    public static class MatrixAlgorithm
    {

        private static int MinimumDistance(double[] distances, bool[] shortestPath, int n)
        {
            double min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < n; ++v)
            {
                if (shortestPath[v] == false && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        
        public static Path  FindShortestPath(Graph graph, Vertex start, Vertex end)
        {
            var path = new Path(graph, start);
            int n = graph.VertexCount;


            double[] distances = new double[n];
            bool[] shortestPath = new bool[n];
            
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue;
                shortestPath[i] = false;
            }

            distances[start.Number - 1] = 0;
            
            for (int i = 0; i < n - 1; i++)
            {
                int u = MinimumDistance(distances, shortestPath, n);
                shortestPath[u] = true;

                for (int v = 0; v < n; v++)
                    if (!shortestPath[v] && Convert.ToBoolean(graph.AdjencyMatrix[u, v]) 
                                         && distances[u] != int.MaxValue 
                                         && distances[u] + graph.AdjencyMatrix[u, v] < distances[v])
                        distances[v] = distances[u] + graph.AdjencyMatrix[u, v];
            }
            
            
            return null;
        }
        
    }
}