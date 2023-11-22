namespace OutKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, -13, 24, 7, -74, -6, 0, 10 };
            int nonPositiveCount;
            List <int> onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
            foreach (int onlyPositiveNumb in onlyPositive) 
            {
                Console.WriteLine(onlyPositiveNumb);
            }

            Console.WriteLine($"Count of non positive is: {nonPositiveCount}");
            Console.ReadKey();
        }

        static List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
        {
            countOfNonPositive = 0;
            List<int> result = new List<int>();
            foreach (int number in numbers) 
            {
                if (number > 0)
                { 
                    result.Add(number); 
                }
                else
                {
                    countOfNonPositive++;
                }
            }
            return result;
        }
    }
}