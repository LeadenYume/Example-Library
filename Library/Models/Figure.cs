namespace Library.Models
{
    public abstract class Figure
    {
        public string Type
        {
            get
            {
                var type = GetType();
                var name = type.Name;
                return name;
            }
        }

        public abstract double CalculateArea();
    }
}
