Rectangle rectangle1 = new Rectangle(5, 10);

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Width is {rectangle1.Height}");

Rectangle rectangle2 = new Rectangle(12, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Width is {rectangle2.Height}");

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
}
