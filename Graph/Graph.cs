using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmOnGraph
{
    public class Graph //todo: implement Graph's Dijkstra and Matrix's Dijkstra and then compare them by elapsed time!
    {
        private double[,] _adjencyMatrix;
        private List<Vertex> _vertices = new();
        private List<Edge> _edges = new();
        public int VertexCount => _vertices.Count;
        public List<Vertex> Vertices => new(_vertices);
        public List<Edge> Edges => new(_edges);

        public double[,] AdjencyMatrix => (double[,])this._adjencyMatrix.Clone();
        
        public Graph(double[,] matrix)
        {
            createGraph(matrix);
            this._adjencyMatrix = (double[,])matrix.Clone(); 
        }

        protected Graph(Graph other)
        {
            this._vertices = new(other.Vertices);
            foreach (var v in this._vertices)
                v.Owner = this;

            this._edges = new(other._edges);
            foreach (var e in _edges)
            {
                e.In.Owner = this;
                e.Out.Owner = this;
            }

            this._adjencyMatrix = (double[,])other._adjencyMatrix.Clone();
        }

        private void createGraph(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                _vertices.Add(new Vertex(this));

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            for (int j = i + 1; j < matrix.GetLength(1); j++)
                if (matrix[i, j] > 0)
                    _edges.Add(new Edge(_vertices[i], _vertices[j], matrix[i, j]));
        }

        public Vertex? this[Vertex vertex] => this._vertices.Find(v => v.Number == vertex.Number);

        public void Dijkstra(Vertex start, Vertex end)
        {
        }
    }
}