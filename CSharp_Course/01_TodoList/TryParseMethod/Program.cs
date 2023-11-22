namespace TryParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // int userAnswer = int.Parse(userInput);
            bool isParsingSuccessful;
            do
            {
                Console.WriteLine("Enter the number:");
                string userInput = Console.ReadLine();

                isParsingSuccessful = int.TryParse(userInput, out int result);

                if (isParsingSuccessful)
                {
                    Console.WriteLine("Parsing worked, number is: " + result);
                }
                else
                {
                    Console.WriteLine("Parsing is not successful");
                }

            }
            while (!isParsingSuccessful);

            Console.ReadKey();
        }
    }
}
