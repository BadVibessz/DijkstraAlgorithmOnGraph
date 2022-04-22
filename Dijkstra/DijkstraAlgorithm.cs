using System;
using System.Collections.Generic;
using System.Linq;

namespace DijkstraAlgorithmOnGraph
{
    public static class DijkstraAlgorithm //todo:
    {
        private static double minDistance(List<DijkstraVertex> vertices)
        {
            //return vertices.Min(v => v.DistanceTo);

            List<DijkstraVertex> temp = new();

            foreach (var v in vertices)
                if (!v.Visited)
                    temp.Add(v);
            
            for (int i = 0; i < temp.Count - 1; i++)
            for (int j = 0; j < temp.Count - i - 1; j++)
                if (temp[j].DistanceTo > temp[j + 1].DistanceTo)
                    (temp[j], temp[j + 1]) = (temp[j + 1], temp[j]);
            return temp.First().DistanceTo;
        }

        private static bool areAllVisited(List<DijkstraVertex> vertices)
        {
            foreach (var v in vertices)
                if (!v.Visited)
                    return false;
            return true;
        }

        public static Path FindShortestPath(Graph graph, Vertex start, Vertex end) //todo: not min, e.g 7 - 2
        {
            var path = new Path(graph, start);
            List<DijkstraVertex> vertices = new();

            foreach (var v in graph.Vertices)
            {
                if (v == start)
                    vertices.Add(new DijkstraVertex(v, 0));
                else vertices.Add(new DijkstraVertex(v, double.PositiveInfinity));
            }

            var current = vertices.Find(v => v.DistanceTo == 0);

            // step of algorithm <-------------------------------------------------------------------------->

            while (!areAllVisited(vertices))
            {
                List<Edge> currentEdges = new();

                foreach (var e in graph.Edges) // find all edges adjacent to current vertex
                {
                    if (e.ConnectedTo(current.Vertex))
                        if (!vertices.Find(v => e.GetAnotherVertex(current.Vertex) == v.Vertex).Visited)
                            currentEdges.Add(e);
                }

                // to find min weighted edge related to current vertex
                for (int i = 0; i < currentEdges.Count - 1; i++) //todo: useless
                for (int j = 0; j < currentEdges.Count - i - 1; j++)
                    if (currentEdges[j].Weight > currentEdges[j + 1].Weight)
                        (currentEdges[j], currentEdges[j + 1]) = (currentEdges[j + 1], currentEdges[j]);

                foreach (var e in currentEdges)
                {
                    var dv = new DijkstraVertex(e.GetAnotherVertex(current.Vertex),
                        current.DistanceTo + e.Weight) { Prev = current };

                    for (int i = 0; i < vertices.Count; i++)
                        if (vertices[i].Vertex == dv.Vertex)
                        {
                            if (vertices[i].DistanceTo >= dv.DistanceTo)
                                vertices[i] = dv;
                            break;
                        }
                }
                
                current.Visited = true;
                
                if (currentEdges.Count > 0)
                {
                    double min = minDistance(vertices);
                    for (int i = 0; i < vertices.Count; i++)
                        if (vertices[i].DistanceTo == min)
                            current = vertices[i];
                }
                else
                {
                    foreach (var v in vertices)
                    {
                        if (!v.Visited)
                        {
                            current = v;
                            break;
                        }
                    }
                }
            }

            var End = vertices.Find(v => v.Vertex == end);
            var _path = new List<Vertex>();

            while (End.Vertex != start)
            {
                _path.Add(End.Vertex);
                End = End.Prev;
            }

            _path.Reverse();
            foreach (var v in _path)
                path.AddVertex(v);

            return path; //todo: reverse
        }
    }
}