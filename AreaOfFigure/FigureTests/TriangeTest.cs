using AreaOfFigure;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTests
{
    [TestFixture]
    public class TriangleTest
    {
        private const double Tolerance = 1e-3;
        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.CalculateArea().Should().BeApproximately(6, Tolerance);
        }
        [Test]
        public void TriangleAreaCalculation2()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            triangle.CalculateArea().Should().BeApproximately(0.433,Tolerance);
        }
        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            triangle.IsRightAngled().Should().Be(true);
        }

        [Test]
        public void NotATriangle()
        {
            Action act = () =>  new Triangle(1, 0, 1);
            act.Should().Throw<Exception>();
        }
    }
}
