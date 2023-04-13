using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace praktica16 {
    public class Giperbola : Functoin
    {
        private double a;

        public Giperbola(double a)
        {
            this.a = a;
        }
        public Giperbola() {
        }
        public override void Draw(Chart chart)
        {
            double y = 0;
            for(int x=-360;x<=360;x++)
            {
                if (x == 0) continue;
                y = a / x;
                chart.Series["Гипербола"].Points.Add(x,y);
            }
        }
    }
}
