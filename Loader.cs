using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithmOnGraph
{
    public class Loader
    {
        private string _filename;

        public Loader(string filename)
        {
            _filename = filename;
        }

        public double[,]? Load()
        {
            StreamReader? sr = null;
            try
            {
                double[,]? result;
                using (StreamReader r = new StreamReader(_filename))
                {
                    int n = 0;
                    while (r.ReadLine() != null)
                        n++;
                    result = new double[n, n];
                }
                
                sr = new StreamReader(_filename);
                int row = 0;
                while (!sr.EndOfStream)
                {
                    var data = sr.ReadLine();
                    if (data is not null)
                    {
                        var vals = data.Split(new[] { ';', ' ', '\n', '\r' });
                        var col = 0;
                        foreach (var val in vals)
                            result[row, col++] = double.Parse(val);

                        row++;
                    }
                }

                return result;
            }
            finally
            {
                sr?.Close();
            }
        }
    }
}