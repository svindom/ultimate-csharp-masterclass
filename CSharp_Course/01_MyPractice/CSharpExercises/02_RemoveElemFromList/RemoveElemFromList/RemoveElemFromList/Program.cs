namespace RemoveElemFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            Adder adder = new Adder(numberList);
            adder.ExecuteAdder();
            

            Console.ReadKey();
        }
    }

    internal class Adder
    {
        private List<int> _numberList;
        public Adder(List<int> numberList)
        {
            _numberList = numberList;
        }

        public void ExecuteAdder()
        {
            AddWordsToList();
            RemoveNumbersLessThanTwelve();
            DisplayResult();
        }


        private void AddWordsToList()
        {
            while (true)
            {
                GetInfo();
                string userInput = Console.ReadLine();
                string[] numbers = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Updated line

                List<int> tempNumberList = new List<int>();
                bool allIntegers = true;
                foreach (string number in numbers)
                {
                    if (!string.IsNullOrWhiteSpace(number) && int.TryParse(number, out int result))
                    {
                        tempNumberList.Add(result);
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input. You might add not a number.");
                        allIntegers = false;
                        break; // Exit foreach loop
                    }
                }

                if (allIntegers) 
                {
                    _numberList.AddRange(tempNumberList);
                    break; // all inputs were valid integers, exit the while loop.
                }
            }
        }

        private void RemoveNumbersLessThanTwelve()
        {
            _numberList.RemoveAll(number => number >= 12);
        }

        private void DisplayResult()
        {

            Console.WriteLine("Numbers that are less than 12 are:");
            foreach (int number in _numberList)
            {
                Console.Write($"{number} ");
            }
        }

        private void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter numbers that you want to add to the list:");
        }
    }
}