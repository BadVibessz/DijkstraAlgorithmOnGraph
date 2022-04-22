using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmOnGraph
{
    public class Edge
    {
        public double Weight { get; set; }
        private Vertex _in;
        private Vertex _out;
        public List<Vertex> Vertices => new() { _in, _out };
        public Vertex In => _in;
        public Vertex Out => _out;

        public Edge(Vertex @in, Vertex @out, double weight)
        {
            _in = @in;
            _out = @out;
            Weight = weight;
        }


        public Vertex GetAnotherVertex(Vertex v)
        {
            if (this._in == v) return this._out;
            return this._in;
        }

        public bool ConnectedTo(Vertex v) => (v == _in || v == _out);
    }
}