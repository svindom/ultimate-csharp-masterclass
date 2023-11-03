using System.Drawing;

Rectangle rectangle1 = new Rectangle(5, 10);
ShapesMeasurementsCalculator calculator = new ShapesMeasurementsCalculator();

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Width is {rectangle1.Height}");
Console.WriteLine($"Area is {calculator.CalculateArea(rectangle1)}");
Console.WriteLine($"Circumference is {calculator.CalculateCircumference(rectangle1)}");

Console.WriteLine();
Rectangle rectangle2 = new Rectangle(12, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Width is {rectangle2.Height}");
Console.WriteLine($"Area is {calculator.CalculateArea(rectangle2)}");
Console.WriteLine($"Circumference is {calculator.CalculateCircumference(rectangle2)}");

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
class ShapesMeasurementsCalculator
{
    public int CalculateCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    public int CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}





















