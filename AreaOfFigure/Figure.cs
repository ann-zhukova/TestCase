using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    public class Figure : IFigure
    {
        Vector2[] points;
        public Figure(Vector2[] v) {
            points = v;
        }
        // для произвольного многоугольника, заданного последовательностью вершин
        // в порядке обхода, можно поступить так:
        // пройдемся по всем ребрам
        // и для каждого добавим в сумму его ориентированную площадь треугольника, заданного этим ребром и началом координат.
        // Все пары вершин, идущие по часовой стрелке, учтутся с отрицательным знаком,
        // а против часовой — с положительным, и поэтому отменят лишнюю площадь
        public double CalculateArea()
        {
            int n = (int)points.Length;
            double s = 0;
            for (int i = 0; i < n; i++)
                s += points[i] ^ points[(i + 1) % n];
            return Math.Abs(s) / 2;
        }
    }
}
