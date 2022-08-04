using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Constants
    {
        public const string RadiusMustBePositiveException = "Radius must be positive number!";
        public const string TriangleEdgesMustBePositiveException = "Triangle edges must be positive numbers!";
        public const string TriangleEdgesMustSatisfyTriangleRule = "Each triangle edge must be smaller than sum of two other edges!";

        public const double CalculationsPrecision = 1e-5;
    }
}
