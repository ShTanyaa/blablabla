using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace praktica16 {
    public class Parabola:Functoin 
    {
        private double a ;
        private double b ;
        private double c ;

        public Parabola(double a,double b,double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void Draw(Chart chart) {
            double y = 0;
            for (int x = -360; x <= 360; x++) {
                y = a *x*x+b*x+c;
                chart.Series["Парабола"].Points.Add(x, y);
            }
        }
    }
}
