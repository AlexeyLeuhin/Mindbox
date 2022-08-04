using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : ISquareCalculatable
    {
        public double EdgeA { get; private set; }
        public double EdgeB { get; private set; }
        public double EdgeC { get; private set; }

        public Triangle(double a, double b, double c)
        {
            ValidateEdges(a, b, c);
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }

        public double GetSquare()
        {
            var semiPerimeter = (EdgeA + EdgeB + EdgeC) / 2;
            var square = Math.Sqrt(semiPerimeter * (semiPerimeter - EdgeA) * (semiPerimeter - EdgeB) * (semiPerimeter - EdgeC));

            return square;
        }

        public bool IsRight()
        {
            double maxEdge = EdgeA, b = EdgeB, c = EdgeC;
            if (b - maxEdge > Constants.CalculationsPrecision)
                DoubleUtils.Swap(ref maxEdge, ref b);

            if (c - maxEdge > Constants.CalculationsPrecision)
                DoubleUtils.Swap(ref maxEdge, ref c);

            return Math.Abs(Math.Pow(maxEdge, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < Constants.CalculationsPrecision;
        }

        private static void ValidateEdges(double a, double b, double c)
        {
            var edges = new List<double>() { a, b, c };
            if (!AllEdgesArePositive(edges))
            {
                throw new ArgumentException(Constants.TriangleEdgesMustBePositiveException);
            }

            if (!EdgesSatisfyTriangleRule(edges))
            {
                throw new ArgumentException(Constants.TriangleEdgesMustSatisfyTriangleRule);
            }
        }

        private static bool EdgesSatisfyTriangleRule(List<double> edges)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                if (edges[i] - (edges[(i + 1) % edges.Count] + edges[(i + 2) % edges.Count]) > Constants.CalculationsPrecision)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool AllEdgesArePositive(List<double> edges)
        {
            return edges.All(edge => edge > Constants.CalculationsPrecision);
        }
    }
}
