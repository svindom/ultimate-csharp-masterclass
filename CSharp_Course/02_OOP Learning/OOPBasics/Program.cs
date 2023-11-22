Rectangle rectangle1 = new Rectangle(5, 10);

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Width is {rectangle1.Height}");
Console.WriteLine($"Area is {rectangle1.CalculateArea()}");
Console.WriteLine($"Circumference is {rectangle1.CalculateCircumference()}");

Console.WriteLine();
Rectangle rectangle2 = new Rectangle(12, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Width is {rectangle2.Height}");
Console.WriteLine($"Area is {rectangle2.CalculateArea()}");
Console.WriteLine($"Circumference is {rectangle2.CalculateCircumference()}");

Console.ReadKey();

class Rectangle
{
    // fields
    public int Width;
    public int Height;

    //constructor
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    //class methods
    public int CalculateCircumference()
    {
        return 2 * Width + 2 * Height;
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}