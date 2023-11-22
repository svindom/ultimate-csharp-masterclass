using System.Diagnostics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 6, 7, 17, 22 };
            var firstFromEnd = numbers[^1]; // the same as we use      = numbers[numbers.Length -1];     to show the last number from the array
            var secondFromEnd = numbers[^2];

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum of the elements is: {sum}");
            

            Console.ReadKey();
        }
    }
}
