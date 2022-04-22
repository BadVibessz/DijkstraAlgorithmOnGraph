using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmOnGraph
{
    public class Vertex
    {
        public int Number { get; }
        public Graph Owner { get; set; }
        public PointF Location { get; set; }

        public Vertex(Graph owner)
        {
            Owner = owner;
            Number = owner.VertexCount + 1;
        }

        public Vertex(Graph owner, int number)
        {
            this.Owner = owner;
            this.Number = number;
        }

        public Vertex CopyTo(Graph newOwner) => new Vertex(newOwner, this.Number);

        public static bool operator ==(Vertex v1, Vertex v2)
        {
            return v1.Owner == v2.Owner && v1.Number == v2.Number;
        }

        public static bool operator !=(Vertex v1, Vertex v2)
        {
            return !(v1 == v2);
        }

        public override string ToString() => this.Number.ToString();

        public static Edge ConnectedWith(Graph g, Vertex v1, Vertex v2)
        {
            if (v1.Owner == v2.Owner)
                foreach (var e in g.Edges)
                    if (e.ConnectedTo(v1) && e.ConnectedTo(v2))
                        return e;

            return null;
        }
    }
}