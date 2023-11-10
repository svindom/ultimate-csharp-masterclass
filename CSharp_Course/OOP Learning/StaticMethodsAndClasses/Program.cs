
Console.WriteLine($"1 + 2 is {Calculator.Add(1,2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");


Console.ReadLine();

// Static class can only contain static methods.
// Hovewer, non-static class can contain static methods.
static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}
