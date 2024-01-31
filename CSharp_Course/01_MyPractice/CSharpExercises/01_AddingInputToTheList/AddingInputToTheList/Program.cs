namespace AddingInputToTheList
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<string> wordsList = new List<string>();
            WordsAdder wordsAdder = new WordsAdder();

            wordsAdder.AddWordsToList(wordsList);
            wordsAdder.DisplayWords(wordsList);

            Console.ReadKey();
        }
    }

    public class WordsAdder
    {
        public WordsAdder()
        {
        }

        public void AddWordsToList(List<string> wordsList) 
        {
            GetDescription();
            // Split the input to the array of words
            string userInput = Console.ReadLine();
            string[] words = userInput.Split(',');

            foreach (string word in words) 
            {
                // Trim to remove any leading or trailing spaces
                wordsList.Add(word.Trim());
            }

        }

        public void DisplayWords(List<string> wordsList)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("You have added the following words to the List:");
            int wordsCounter = 0;
            foreach (string word in wordsList)
            {
                wordsCounter++;
                Console.WriteLine($"{wordsCounter}. {word}");
            }
        }

        public void GetDescription()
        {
            Console.WriteLine("Please enter words separated by commas that you want to add to the list:");
        }
    }
}

