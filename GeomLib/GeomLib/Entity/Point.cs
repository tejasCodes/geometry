using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib
{
    public class Point
    {
        private double _x;
        private double _y;
        private double _z;

        /// <summary>
        /// default constructor
        /// </summary>
        public Point()
        {
            _x = 0.0;
            _y = 0.0;
            _z = 0.0;
        }

        public Point(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        /// <summary>
        /// computes the distance between two points
        /// </summary>
        /// <param name="ptA"></param>
        /// <param name="ptB"></param>
        /// <returns></returns>
        public double DistanceBetween(Point ptA, Point ptB)
        {
            var dist = 0.0;
            try
            {
                dist = Math.Sqrt(
                    Math.Pow(ptA.X() - ptB.X(), 2) +
                    Math.Pow(ptA.Y() - ptB.Y(), 2) +
                    Math.Pow(ptA.Z() - ptB.Z(), 2));
            }
            catch (Exception)
            {
            }
            return dist;
        }

        public void setX(double x)
        {
            _x = x;
        }

        public void setY(double y)
        {
            _y = y;
        }

        public void setZ(double z)
        {
            _z = z;
        }

        public double getX()
        {
            return _x;
        }

        public double getY()
        {
            return _y;
        }

        public double getZ()
        {
            return _z;
        }

        public double X()
        {
            return _x;
        }

        public double Y()
        {
            return _y;
        }
        public double Z()
        {
            return _z;
        }

    }
}
