using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraAlgorithmOnGraph
{
    public class GraphPainter
    {
        private Graph _graph;
        private int vertexSize = 30;
        private Color _oldColor = Color.BlueViolet;

        public GraphPainter(Graph graph, Control panel)
        {
            _graph = graph;
        }

        public void Paint(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var r = Rectangle.Ceiling(g.VisibleClipBounds);

            var vertices = _graph.Vertices;
            var edges = _graph.Edges;

            var pen = new Pen(Color.BlueViolet, 2) { EndCap = LineCap.Round };
            var font = new Font("Arial", 15);
            float angle = 360f / this._graph.VertexCount;

            Point center = new Point(r.Width / 2, r.Height / 2);

            double cos = Math.Cos(angle * Math.PI / 180);
            double sin = Math.Sin(angle * Math.PI / 180);
            for (int i = 0; i < vertices.Count; i++)
            {
                Point vertLocToPanel = new Point(center.X, (int)(center.Y - r.Height / 2.25));

                if (i != 0)
                {
                    (vertLocToPanel.X, vertLocToPanel.Y) = ((int)(cos * (vertices[i - 1].Location.X - center.X) -
                            sin * (vertices[i - 1].Location.Y - center.Y) + center.X),
                        (int)(sin * (vertices[i - 1].Location.X - center.X) +
                              cos * (vertices[i - 1].Location.Y - center.Y) + center.Y));
                }

                vertices[i].Location = vertLocToPanel;
            }

            foreach (var e in edges)
            {
                Point p1 = new Point((int)e.In.Location.X + vertexSize / 2, (int)e.In.Location.Y + vertexSize / 2);
                Point p2 = new Point((int)e.Out.Location.X + vertexSize / 2, (int)e.Out.Location.Y + vertexSize / 2);
                g.DrawLine(pen, p1, p2);

                double x = p2.X - p1.X;
                double y = p2.Y - p1.Y;


                Point p = new Point((int)(p1.X + x / 2), (int)(p1.Y + y / 2));
                g.DrawString(e.Weight.ToString(), font, new SolidBrush(Color.Black), p);
            }

            foreach (var v in vertices)
            {
                g.FillEllipse(new SolidBrush(Color.White), v.Location.X, v.Location.Y, vertexSize, vertexSize);
                g.DrawEllipse(pen, v.Location.X, v.Location.Y, vertexSize, vertexSize);
                g.DrawString(v.Number.ToString(), font, new SolidBrush(Color.BlueViolet),
                    new PointF(v.Location.X + vertexSize / 7, v.Location.Y + vertexSize / 7));
            }
        }

        public void HighLightPath(Graphics g, Path path)
        {
            if(g is null || path is null) return;

            var rand = new Random();
            var color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

            while (_oldColor == color)
                color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));

            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(color, 4) { EndCap = LineCap.Round };

            for (int i = 0; i < path.Vertices.Count - 1; i++)
            {
                Point p1 = new Point((int)path.Vertices[i].Location.X + vertexSize / 2, (int)path.Vertices[i].Location.Y + vertexSize / 2);
                Point p2 = new Point((int)path.Vertices[i + 1].Location.X + vertexSize / 2, (int)path.Vertices[i + 1].Location.Y + vertexSize / 2);
                g.DrawLine(pen, p1, p2);
            }

            foreach (var v in path.Vertices)
            {
                g.FillEllipse(new SolidBrush(Color.White), v.Location.X, v.Location.Y, vertexSize, vertexSize);
                g.DrawEllipse(pen, v.Location.X, v.Location.Y, vertexSize, vertexSize);
                g.DrawString(v.Number.ToString(), new Font("Arial", 15), new SolidBrush(color),
                    new PointF(v.Location.X + vertexSize / 7, v.Location.Y + vertexSize / 7));
            }

            _oldColor = color;
        }
    }
}