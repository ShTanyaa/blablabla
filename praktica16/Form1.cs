using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktica16
{
    public partial class Form1 : Form
    {
        Functoin f;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = 0;
            for(int x=-360;x<=360;x++)
            {
                y = Math.Sin(Math.PI / 180 * x);
                chart1.Series["синус"].Points.AddXY(x, y);
                y = Math.Cos(Math.PI / 180 * x);
                chart1.Series["косинус"].Points.AddXY(x, y);
            }
            
        }

        private void button2_Click(object sender, EventArgs e) {
        }

        private void синусToolStripMenuItem_Click(object sender, EventArgs e) {
           
        }

        private void синусToolStripMenuItem_Click_1(object sender, EventArgs e) {

        }

        private void синусToolStripMenuItem1_Click(object sender, EventArgs e) {
            double y = 0;
            for (int x = -360; x <= 360; x++) {
                y = Math.Sin(Math.PI / 180 * x);
                chart1.Series["синус"].Points.AddXY(x, y);
            }
        }

        private void косинусToolStripMenuItem_Click(object sender, EventArgs e) {
            double y = 0;
            for (int x = -360; x <= 360; x++) {
                y = Math.Cos(Math.PI / 180 * x);
                chart1.Series["косинус"].Points.AddXY(x, y);
            }
        }

        private void гиперболаToolStripMenuItem_Click(object sender, EventArgs e) {
            double a = (double)numericUpDown1.Value;
            f = new Giperbola(a);
            f.Draw(chart1);
        }

        private void параболаToolStripMenuItem_Click(object sender, EventArgs e) {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;
            f = new Parabola(a,b,c);
            f.Draw(chart1);
        }

        private void кубФToolStripMenuItem_Click(object sender, EventArgs e) {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown1.Value;
            f = new Kub_fun(a,b);
            f.Draw(chart1);
        }

        private void синToolStripMenuItem_Click(object sender, EventArgs e) {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown1.Value;
            f = new Sin(a, b);
            f.Draw(chart1);
        }

        private void косToolStripMenuItem_Click(object sender, EventArgs e) {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown1.Value;
            f = new Cos(a, b);
            f.Draw(chart1);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
        }
    }
}
