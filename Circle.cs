using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
            if (Radius <= 0)
            {
                throw new ArgumentException("Not circle");
            }
        }

        protected sealed override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
