using AreaOfFigure;
using FluentAssertions;

namespace FigureTests
{
    [TestFixture]
    public class FigureTests
    {
        private const double Tolerance = 1e-3;
        [Test]
        public void FigureAreaCalculation()
        {
            Vector2[] points = new Vector2[] { new Vector2(0,0), new Vector2(0,1), new Vector2(1,1), new Vector2(1,0)};
            Figure square = new Figure(points);
            square.CalculateArea().Should().BeApproximately(1, Tolerance);
        }
        [Test]
        public void FigureAreaCalculation2()
        {
            Vector2[] points = new Vector2[] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(2, 1), new Vector2(2, 0) };
            Figure square = new Figure(points);
            square.CalculateArea().Should().BeApproximately(2, Tolerance);
        }
        [Test]
        public void FigureAreaCalculation3()
        {
            Vector2[] points = new Vector2[] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 2), new Vector2(2, 2), new Vector2(2, 0) };
            Figure pentagon= new Figure(points);
            pentagon.CalculateArea().Should().BeApproximately(3.5, Tolerance);
        }
    }
}
