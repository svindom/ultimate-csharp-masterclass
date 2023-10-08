namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            var userChoise = Console.ReadLine().ToLower();

            if (userChoise == "S")
            {
                PrintSelectedOption("See al TODOs");
            }
            else if (userChoise == "A") 
            {
                PrintSelectedOption("Add a TODO");
            }
            else if (userChoise == "R")
            {
                PrintSelectedOption("Remove a TODO");
            }
            else if (userChoise == "E")
            {
                PrintSelectedOption("Exit");
            }

            Console.ReadKey();

            void PrintSelectedOption (string selectedOption)
            {
                Console.WriteLine("Selected option: " + selectedOption);
            }
        }
    }
}