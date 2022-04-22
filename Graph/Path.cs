using System.Collections.Generic;

namespace DijkstraAlgorithmOnGraph
{
    public class Path : Graph
    {
        private Stack<Vertex> _vertices = new();

        public int Length { get; private set; }

        public List<Vertex> Vertices
        {
            get
            {
                var v = new List<Vertex>(_vertices);
                v.Reverse(0, v.Count);
                return v;
            }
        }

        public Path(Graph other, Vertex start) : base(other)
        {
            this._vertices.Push(start);
        }

        public Path AddVertex(Vertex v)
        {
            this._vertices.Push(v);
            return this;
        }
    }
}