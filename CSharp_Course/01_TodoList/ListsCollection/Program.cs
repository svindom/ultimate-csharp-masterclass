namespace ListsCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "One",
                "Two",
            };
            Console.WriteLine("Count of elements is " + words.Count);

            words.Add("a");
            Console.WriteLine("Count of elements is " + words.Count);

            words[0] = "Once";

            foreach (string word in words) 
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("------------------------------------------------------------------------------");

            // also we can use a for loop too
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------Removing an item--------------------------");
            words.Remove("Two");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------Adding new items using Array--------------------------");

            words.AddRange(new[] {"three", "uno", "santa"});

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}