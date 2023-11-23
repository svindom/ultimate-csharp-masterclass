List<int> numbers = new List<int> { 1, 4, 6 - 1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = true;

int sum;
if (shallAddPositiveOnly)
{
    sum = new PositiveNumberSumCalculator().Calculator(numbers);
}
else
{
    sum = new NumberSumCalculator().Calculator(numbers);
}

Console.WriteLine($"Sum is: {sum}");

Console.ReadKey();

public class NumberSumCalculator
{
    public int Calculator(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }
    protected virtual bool ShallBeAdded (int number)
    {
        return true;
    }
}

public class PositiveNumberSumCalculator : NumberSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}