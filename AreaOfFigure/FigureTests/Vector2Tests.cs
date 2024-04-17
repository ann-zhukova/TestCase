using AreaOfFigure;
using FluentAssertions;

namespace FigureTests
{
    [TestFixture]
    public class Vector2Tests
    {
        private const double Tolerance = 1e-3;
        [Test]
        public void ZeroVectorProductTest1()
        {
            Vector2 v = new Vector2(0, 0);
            Vector2 u = new Vector2(1, 1);
            double res = v ^ u;
            res.Should().BeApproximately(0,Tolerance);
        }
        [Test]
        public void ParallelVectorProductTest()
        {
            Vector2 v = new Vector2(1, 1);
            Vector2 u = new Vector2(1, 1);
            double res = v ^ u;
            res.Should().BeApproximately(0, Tolerance);
        }
        [Test]
        public void VectorProductTest()
        {
            Vector2 v = new Vector2(2, 1);
            Vector2 u = new Vector2(3, 4);
            double res = v ^ u;
            res.Should().BeApproximately(5, Tolerance);
        }
        [Test]
        public void DotProductTest()
        {
            Vector2 v = new Vector2(2, 1);
            Vector2 u = new Vector2(3, 4);
            double res = v * u;
            res.Should().BeApproximately(10, Tolerance);
        }
        [Test]
        public void ZeroDotProductTest()
        {
            Vector2 v = new Vector2(0, 1);
            Vector2 u = new Vector2(1, 0);
            double res = v * u;
            res.Should().BeApproximately(0, Tolerance);
        }
    }
}
