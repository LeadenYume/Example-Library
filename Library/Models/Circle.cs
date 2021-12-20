using System;

namespace Library.Models
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public static bool IsCircle(Figure figure)
        {
            return figure.Type == typeof(Circle).Name;
        }
    }
}
