using AreaOfFigure;
using NUnit.Framework;
using FluentAssertions;
namespace AreaOfFigureTests
{
    [TestFixture]
    public class CircleTests
    {
        private const double Tolerance = 1e-2;
        [Test]
        public void TestZeroCicle()
        {
            Circle circle = new Circle(0);
            circle.CalculateArea().Should().BeApproximately(0, Tolerance);
        }
        [Test]
        public void TestOneCicle() 
        {  
            Circle circle = new Circle(1);
            circle.CalculateArea().Should().BeApproximately(Math.PI, Tolerance);
        }
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            circle.CalculateArea().Should().BeApproximately(78.53, Tolerance);
        }
    }
}