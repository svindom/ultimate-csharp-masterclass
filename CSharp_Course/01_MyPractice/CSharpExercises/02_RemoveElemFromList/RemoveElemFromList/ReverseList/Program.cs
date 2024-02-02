namespace ReverseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // how to reverse List numbers manually

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> reverseNumbers = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                reverseNumbers.Add(numbers[i]);
            }

            Console.WriteLine("Numbers in the list are:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Reversed numbers are: ");
            foreach (int number in reverseNumbers) 
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            // Another more simple way to reverse List elements

            List<int> numbersList = new List<int>() { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
            numbersList.Reverse();
            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}