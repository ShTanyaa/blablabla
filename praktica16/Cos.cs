using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace praktica16 {
    internal class Cos:Functoin {
        private double a ;
        private double b ;

        public Cos(double a, double b) {
            this.a = a;
            this.b = b;
        }
        public override void Draw(Chart chart) {
            double y = 0;
            for (int x = -360; x <= 360; x++) {
                y = Math.Cos(a * x) + b;
                chart.Series["cos"].Points.Add(x, y);
            }
        }
    }
}
