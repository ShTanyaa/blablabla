using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace praktica16 {
    public class Sin:Functoin {
        private double a ;
        private double b ;

        public Sin(double a, double b) {
            this.a = a;
            this.b = b;
        }
        public override void Draw(Chart chart) {
            double y = 0;
            for (int x = -360; x <= 360; x++) {
                y = Math.Sin(a * x) + b;
                chart.Series["sin"].Points.Add(x, y);
            }
        }
    }
}
