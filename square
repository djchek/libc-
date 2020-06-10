using System;

namespace Square
{
    public class Triangle
    {
        private readonly Lazy<bool> _RightTriangle;
        
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public bool RightTriangle => _RightTriangle.Value;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            _RightTriangle = new Lazy<bool>(CheckRightTriangle);
        }
        
        private bool CheckRightTriangle()
        {
            if ((A*A + B*B == C*C) || (A*A + C*C == B*B)|| (A*A == B*B + C*C))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public static double AreaTriangle()
        {
            var p = (A + B + C) / 2;
            var firstcoef = p - A;
            var secondcoef = p - B;
            var thirdcoef = p - C;
            return Math.Sqrt(p*firstcoef * secondcoef * thirdcoef);
        }

    }
    public class Circle
    {
        public double Radius { get; }
        
        public Circle (double radius)
        {
            Radius = radius;
        }

        public static double AreaCircle()
        {
            return Math.Pi * Math.Pow(radius, 2);
        }
    }
}
