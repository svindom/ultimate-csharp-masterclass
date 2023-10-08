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
            Console.WriteLine("Hello");
            Console.WriteLine("Input your first number");
            int inputIntFirstNum = GetValidIntegerInput();

            Console.WriteLine("Input your second number");
            int inputIntSecondNum = GetValidIntegerInput();

            Console.WriteLine("What do you want to do with those numbers?\n[A]dd\n[S]ubtract\n[M]ultiply");
            while (true) 
            {
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "A" || userInput == "a")
                {
                    var result = inputIntFirstNum + inputIntSecondNum;
                    Console.WriteLine($"{inputIntFirstNum} + {inputIntSecondNum} = {result}");
                    break;
                }
                else if (userInput == "S" || userInput == "s") 
                {
                    var result = inputIntFirstNum - inputIntSecondNum;
                    Console.WriteLine($"{inputIntFirstNum} - {inputIntSecondNum} = {result}");
                    break;
                }
                else if (userInput == "M" || userInput == "m")
                {
                    var result = inputIntFirstNum * inputIntSecondNum;
                    Console.WriteLine($"{inputIntFirstNum} * {inputIntSecondNum} = {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    Console.WriteLine("What do you want to do with those numbers?\n[A]dd\n[S]ubtract\n[M]ultiply");
                }
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static int GetValidIntegerInput()
        {
            int validInt;
            while (true)
            {
                var userInput = Console.ReadLine().ToLower();
                if (int.TryParse(userInput, out validInt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                }
            }
            return validInt;
        }
    }
}
