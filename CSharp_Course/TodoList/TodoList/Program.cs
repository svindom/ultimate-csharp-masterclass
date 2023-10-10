namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            var userInput = Console.ReadLine();

            while (userInput.Length < 15)
            {
                userInput += 'a';
                Console.WriteLine(userInput);
            }
            Console.WriteLine("The loop is finished");


            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("[S]ee all TODOs");
            //Console.WriteLine("[A]dd a TODO");
            //Console.WriteLine("[R]emove a TODO");
            //Console.WriteLine("[E]xit");

            //var userChoise = Console.ReadLine().ToUpper();

            //switch(userChoise)
            //{
            //    case "S":
            //        PrintSelectedOption("See all TODOs");
            //        break;
            //    case "A":
            //        PrintSelectedOption("Add a TODO");
            //        break;
            //    case "R":
            //        PrintSelectedOption("Remove a TODO");
            //        break;
            //    case "E":
            //        PrintSelectedOption("Exit");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;
            //}



            //if (userChoise == "S")
            //{
            //    PrintSelectedOption("See all TODOs");
            //}
            //else if (userChoise == "A") 
            //{
            //    PrintSelectedOption("Add a TODO");
            //}
            //else if (userChoise == "R")
            //{
            //    PrintSelectedOption("Remove a TODO");
            //}
            //else if (userChoise == "E")
            //{
            //    PrintSelectedOption("Exit");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choise");
            //}

            Console.ReadKey();

            void PrintSelectedOption (string selectedOption)
            {
                Console.WriteLine("Selected option: " + selectedOption);
            }

            char ConvertPointsToGrade (int points)
            {
                char grade;
                if (points == 10 || points == 9) 
                {
                    grade = 'A';
                }
                else if (points <=8 && points >= 6)
                {
                    grade = 'B';
                }
                else if (points <=5 && points >= 3)
                {
                    grade = 'C';
                }
                else if(points == 2 || points == 1)
                {
                    grade = 'D';
                }
                else if (points == 0)
                {
                    grade = 'E';
                }
                else
                {
                    grade = '!';
                }

                return grade;
            }
        }
    }
}