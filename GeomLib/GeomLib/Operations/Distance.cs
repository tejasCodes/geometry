using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Operations
{
    class Distance
    {
        /// <summary>
        /// computes the distance between 2 points
        /// </summary>
        /// <param name="ptA">point 1</param>
        /// <param name="ptB">point 2</param>
        /// <returns></returns>
        public double DistanceBetween(Point3d ptA, Point3d ptB)
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
    }
}
