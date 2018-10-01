using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_DoCirclesIntersect
{
    class Circle
    {
        public Circle(double[] center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }
        private double[] center;
        private double radius;

        public double[] GetCenter() => center;
        public double GetRadius() => radius;
    }
}
