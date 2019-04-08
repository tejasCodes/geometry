using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Entity
{
    class Point2d
    {
        private double _x;
        private double _y;

        /// <summary>
        /// default constructor
        /// </summary>
        public Point2d()
        {
            _x = 0.0;
            _y = 0.0;
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void setX(double x)
        {
            _x = x;
        }

        public void setY(double y)
        {
            _y = y;
        }

        public double getX()
        {
            return _x;
        }

        public double getY()
        {
            return _y;
        }

        public double X()
        {
            return _x;
        }

        public double Y()
        {
            return _y;
        }
    }
}
