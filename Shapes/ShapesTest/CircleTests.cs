using NUnit.Framework;
using Shapes;
using System;

namespace ShapesTest
{
    public class CircleTests
    {
        [Test]
        public void TryingToCreateNegativeRadiusCircle_ShouldThrowException()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-10));
        }

        [Test]
        public void CreatingCorrectCircle_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => new Circle(10));
        }

        [Test]
        public void TryingToCreateZeroRadiusCircle_ShouldThrowException()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [TestCase(1)]
        [TestCase(1.23)]
        [TestCase(100)]
        public void CalculatingCircleSquare_ShouldReturnCorrectResult(double radius)
        {
            var circle = new Circle(radius);
            var correctRadius = Math.PI * Math.Pow(radius, 2);

            Assert.Less(Math.Abs(circle.GetSquare() - correctRadius), Constants.CalculationsPrecision);
        }
    }
}