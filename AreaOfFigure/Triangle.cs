using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigure
{
    // класс Треугольник наследует класс многоугольник
    public class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c) :base(ConvertSidesToArray(a,b,c))
        {
            // проверка на существование треугольника
            if (a + b <= c || b + c <= a || a + c <= b)
                throw new Exception("Такого треугольника не существует");
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static Vector2[] ConvertSidesToArray(double a, double b, double c)
        {
            // теормеа косинусов 
            var angleA = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            var point1 = new Vector2(0, 0);
            var point2 = new Vector2(a, 0);
            var point3 = new Vector2(c * Math.Cos(angleA), c * Math.Sin(angleA));
            Vector2[] result = new Vector2[] {point1, point2, point3};
            return result;
        }

        public bool IsRightAngled()
        {
            //теорема Пифогора
            return a * a + b * b == c * c ||
                   a * a + c * c == b * b ||
                   b * b + c * c == a * a;
        }
    }
}
