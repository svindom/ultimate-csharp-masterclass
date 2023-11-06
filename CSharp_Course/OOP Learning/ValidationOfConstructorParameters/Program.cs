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
    const int NumberOfSides = 4;
    public readonly int Width;
    public readonly int Height;

    //constructor
    public Rectangle(int width, int height)
    {
        Width = GetLenghtOrDefault(width, nameof(Width));       //It will return a string equal to the name of the given thing. In our case from the field name.
        Height = GetLenghtOrDefault(height, nameof(Height));
    }


    private int GetLenghtOrDefault(int lenght, string name)
    {
        const int DefaultValueIfNonPositive = 1;
        if (lenght <= 0)
        {
            Console.WriteLine($"{name} must be positive number");
            return DefaultValueIfNonPositive;
        }
        return lenght;


    }

}

class ShapesMeasurementsCalculator
{
    public int CalculateCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height; // check the same methods in the OOP Learning section to see the difference between each others.


    public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;

}