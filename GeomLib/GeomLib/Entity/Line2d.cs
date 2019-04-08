using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Entity
{
    class Line2d
    {
        Point2d _ptA;
        Point2d _ptB;

        /// <summary>
        /// default constructor
        /// </summary>
        public Line2d()
        {
            _ptA = new Point2d();
            _ptB = new Point2d();
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="ptA"></param>
        /// <param name="ptB"></param>
        public Line2d(Point2d ptA, Point2d ptB)
        {
            _ptA = ptA;
            _ptB = ptB;
        }

        /// <summary>
        /// compute the slope of the line
        /// </summary>
        /// <returns>the slope of the line</returns>
        public double Slope()
        {
            var slope = 0.0;
            try
            {
                // slope m = (yb-ya) / (xb - xa)
                slope = (_ptB.Y() - _ptA.Y()) /
                    (_ptB.X() - _ptA.X());
            }
            catch (Exception)
            {
            }
            return slope;
        }

        public string Equation()
        {
            var equation = "";
            try
            {
                // equation of line > y = mx + b
                // compute m = slope
                var m = Slope();

                // compute b = y - mx
                var b = _ptA.Y() - m * _ptA.X();

                equation = "y = " + m + "x" + " + " + b;
            }
            catch (Exception)
            {
            }
            return equation;
        }

    }
}
