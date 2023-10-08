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

            var userChoise = Console.ReadLine();

            if (userChoise == "S")
            {
                PrintSelectedOption("See al TODOs");
            }

            Console.ReadKey();

            void PrintSelectedOption (string selectedOption)
            {
                Console.WriteLine("Selected option: " + selectedOption);
            }
        }
    }
}