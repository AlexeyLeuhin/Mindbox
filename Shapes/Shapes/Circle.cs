using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : ISquareCalculatable
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            ValidateRadius(radius);
            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private static void ValidateRadius(double radius)
        {
            if (radius < Constants.CalculationsPrecision)
            {
                throw new ArgumentException(Constants.RadiusMustBePositiveException);
            }
        }
    }
}
