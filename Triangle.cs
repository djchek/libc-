using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Triangle : Figure
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
            _RightTriangle = new Lazy<bool>(IsRightAngled);
            if ((A + B) < C || (A + C) < B || (B + C) < A)
            {
                throw new ArgumentException("Not triangle");
            }

            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("Side <= 0");
            }
        }

        private bool IsRightAngled()
        {
            var maxSide = new[] { A, B, C }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == A * A + B * B + C * C;
        }

        protected sealed override double Area()
        {
            var p = (A + B + C) / 2;
            var firstcoef = p - A;
            var secondcoef = p - B;
            var thirdcoef = p - C;
            return Math.Sqrt(p * firstcoef * secondcoef * thirdcoef);
        }

    }
}