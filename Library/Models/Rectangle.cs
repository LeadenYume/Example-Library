namespace Library.Models
{
    public class Rectangle : Figure
    {
        public double A { get; }
        public double B { get; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double CalculateArea()
        {
            return A * B;
        }

        public static bool IsRectangle(Figure figure)
        {
            return figure.Type == typeof(Rectangle).Name;
        }
    }
}
