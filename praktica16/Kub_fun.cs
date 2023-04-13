using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace praktica16 {
    public class Kub_fun:Functoin {
            private double b ;
        private double a ;

        public Kub_fun(double b,double a) {
                this.b = b;
            this.a = a;
            }
            public override void Draw(Chart chart) {
                double y = 0;
            chart.Series["Кубическая функция"].Points.Clear();
                for (int x = -360; x <= 360; x++) {
                    y = a+b*x*x*x;

                    chart.Series["Кубическая функция"].Points.Add(x, y);
                }
            }
        }
}
