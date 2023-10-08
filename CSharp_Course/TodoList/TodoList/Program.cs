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

            string userChoice = Console.ReadLine();
            Console.WriteLine("User input " + userChoice);
            userChoice = "ABC";

            Console.ReadKey();
        }
    }
}