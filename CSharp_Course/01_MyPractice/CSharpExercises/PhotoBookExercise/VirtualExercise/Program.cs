namespace VirtualExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(123.4);
            Rectangle rectangle = new Rectangle(234, 78.5);

            Console.WriteLine($"Circle with radius {circle.Radius} has an area of {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle with length {rectangle.Length} and width {rectangle.Width} has an area of {rectangle.CalculateArea()}");

            Console.ReadKey();
        }
    }

    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape 
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

}
