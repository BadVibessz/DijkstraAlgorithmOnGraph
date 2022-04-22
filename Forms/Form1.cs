using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraAlgorithmOnGraph
{
    public partial class Form1 : Form
    {
        private Loader l = new Loader("data.csv");
        private Graph _graph;
        private GraphPainter _graphPainter;

        public Form1()
        {
            InitializeComponent();

            this.panel1.BackColor = Color.White;

            var d = l.Load();
            _graph = new Graph(d);
            _graphPainter = new GraphPainter(_graph, this.panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _graphPainter.Paint(e.Graphics);
        }

        private void dijkstraBtn_Click(object sender, EventArgs e) //todo: paint
        {
            Vertex start = this._graph.Vertices[0];
            Vertex end = this._graph.Vertices[0];
            var form = new DijkstraSetter(this._graph);
            form.ShowDialog();
            _graphPainter.HighLightPath(this.panel1.CreateGraphics(),form.Path);
        }
    }
}