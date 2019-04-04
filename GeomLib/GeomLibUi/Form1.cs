using GeomLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomLibUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// point 1 x1 value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationX1Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }

        /// <summary>
        /// point 1 y1 value chaged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationY1Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }

        /// <summary>
        /// point 1 z1 value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationZ1Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }

        /// <summary>
        /// point 2 x2 value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationX2Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }

        /// <summary>
        /// point 2 y2 value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationY2Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }

        /// <summary>
        /// point 3 z2 value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DistanceCalculationZ2Changed(object sender, EventArgs e)
        {
            Point a = new Point(Double.Parse(X1.Text), Double.Parse(Y1.Text), Double.Parse(Z1.Text));
            Point b = new Point(Double.Parse(X2.Text), Double.Parse(Y2.Text), Double.Parse(Z2.Text));
            totalDist.Text = a.DistanceBetween(a, b).ToString();
        }
    }
}
