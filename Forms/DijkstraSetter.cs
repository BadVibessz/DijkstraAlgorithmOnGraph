using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DijkstraAlgorithmOnGraph
{
    public partial class DijkstraSetter : Form
    {
        private Graph _graph;
        public Path Path { get; private set; }

        public DijkstraSetter(Graph graph)
        {
            InitializeComponent();

            this._graph = graph;
            this.startNumeric.Maximum = this._graph.VertexCount;
            this.endNumeric.Maximum = this._graph.VertexCount;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var start = this._graph.Vertices.Find(v => v.Number == startNumeric.Value);
            var end = this._graph.Vertices.Find(v => v.Number == endNumeric.Value);
            this.Close();

            this.Path = DijkstraAlgorithm.FindShortestPath(this._graph, start, end);
        }
    }
}