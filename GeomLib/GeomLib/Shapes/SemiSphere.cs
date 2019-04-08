using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomLib.Shapes
{
    class SemiSphere
    {
        private double _radius;

        /// <summary>
        /// default constructor
        /// </summary>
        public SemiSphere()
        {
            _radius = 0.0;
        }

        /// <summary>
        /// parametrized constructor
        /// </summary>
        public SemiSphere(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// volume of semisphere
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            return (2 / 3) * Math.PI * Math.Pow(_radius, 3);
        }

        /// <summary>
        /// compute the surface area of semisphere
        /// </summary>
        /// <returns></returns>
        public double SurfaceArea()
        {
            return 3 * Math.PI * Math.Pow(_radius, 2);
        }

    }
}
