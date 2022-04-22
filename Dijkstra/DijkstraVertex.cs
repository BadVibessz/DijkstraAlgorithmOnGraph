namespace DijkstraAlgorithmOnGraph
{
    public class DijkstraVertex
    {
        public Vertex Vertex { get; set; }
        public double DistanceTo { get; set; }
        //public Path PathTo { get; set; }

        public bool Visited { get; set; }
        
        public DijkstraVertex Prev { get; set; }

        public DijkstraVertex(Vertex v, double dist, bool visited = false)
        {
            this.Vertex = v;
            this.DistanceTo = dist;
            //this.PathTo = path;
            this.Visited = visited;
        }
    }
}