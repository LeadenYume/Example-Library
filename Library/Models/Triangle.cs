using System;

namespace Library.Models
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            var p = (A + B + C) / 2;
            var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return s;
        }

        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            bool isRight(double a, double b, double c) => (a * a + b * b == c * c);

            return isRight(A, B, C) || isRight(B, C, A) || isRight(C, A, B);
        }

        /// <summary>
        /// Определяет, является ли фигура треугольником
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public static bool IsTriangle(Figure figure)
        {
            return figure.Type == typeof(Triangle).Name;
        }
    }
}
