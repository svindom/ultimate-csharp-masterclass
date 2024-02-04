namespace RecursionEexercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Itteration recursion = new Itteration();

            int positiveNumber = recursion.GetPositiveNumber();
            recursion.PrintTheResult(positiveNumber);

            Console.ReadKey();
        }
    }


    class Itteration
    {
        public int GetPositiveNumber()
        {
            int positiveNumber = 0; // Initialize positeveNumber with a default value
            while (true) // Use an infinite loop that we'll break out of on valid input
            {
                Console.WriteLine("Enter any positive natural number which will be printed:");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out positiveNumber) && positiveNumber > 0)
                {
                    return positiveNumber; // Return and barake a loop immediatelly upon receiving valid input
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a positive number");
                    Console.WriteLine();
                }
            }
            // No need for return staetment here because the loop cannot exit without returning a valid number
        }
        public void PrintTheResult(int positiveNumber)
        {
            Console.WriteLine();
            for (int i = 1; i <= positiveNumber; i++) // Start from 1 to match the user input expectation
            {
                if (i < positiveNumber) // For numbers before the last one, add a comma and space
                {
                    Console.Write(i + ", "); 
                }
                else // For the last number, just print the number without a comma and space
                {
                    Console.Write(i); 
                }
            }
        }
    }
}