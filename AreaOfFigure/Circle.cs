using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    // класс круг реализует интерфейс IFigure
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
