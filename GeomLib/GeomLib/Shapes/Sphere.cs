using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Shapes
{
    class Sphere
    {
        private double _radius;

        /// <summary>
        /// default constructor
        /// </summary>
        public Sphere()
        {
            _radius = 0.0;
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// compute the volume of sphere
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(_radius, 3);
        }

        /// <summary>
        /// compute the surface area of sphere
        /// </summary>
        /// <returns></returns>
        public double SurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(_radius, 2);
        }
    }
}
