using NUnit.Framework;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTest
{
    public class TriangleTests
    {
		[TestCase(-5,25, 3)]
		[TestCase(0.5, -2, 7)]
		[TestCase(10, 11, -12)]
		public void TryingToCreateTriangleWithNegativeEdges_ShouldThrowException(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}

		[TestCase(2, 7, 2)]
		[TestCase(1, 1, 10)]
		[TestCase(3, 0.5, 0.7)]
		public void TryingToCreateTriangleThatDoseNotSatisfyTriangleRule_ShouldThrowException(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Test]
		public void CreatingCorrectTriangle_ShouldNotThrowException()
		{
			Assert.DoesNotThrow(() => new Triangle(3, 4, 5));
		}

		[TestCase(3, 4, 5, true)]
		[TestCase(2, 2, 2, false)]
		public void CreatingCorrectTriangles_ShouldCheckIfIsRightOrNot(double a, double b, double c, bool isRight)
		{
			var triangle = new Triangle(a, b, c);
			Assert.AreEqual(triangle.IsRight(), isRight);
		}

		[TestCase(3, 4, 5, 6)]
		[TestCase(6, 8, 10, 24)]
		public void GetSquareTest(double a, double b, double c, double correctSquare)
		{
			var triangle = new Triangle(a, b, c);
			var square = triangle.GetSquare();

			Assert.Less(Math.Abs(square - correctSquare), Constants.CalculationsPrecision);
		}
	}
}
