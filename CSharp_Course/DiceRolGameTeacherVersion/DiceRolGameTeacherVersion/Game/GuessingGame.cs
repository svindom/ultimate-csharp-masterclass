
using DiceRolGameTeacherVersion.UserCommunication;

namespace DiceRolGameTeacherVersion.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;

        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
        public static void PrintResult(GameResult gameResult)
        {
            //string message;
            //if (gameResult == GameResult.Victory)
            //{
            //    message = "You win!";
            //}
            //else
            //{
            //    message = "You lose :(";
            //}


            // Another way to diclare what we have above ⇑
            string message = gameResult == GameResult.Victory
                ? "You win!"
                : "You lose :(";

            Console.WriteLine(message);
        }

        public GameResult Play()
        {
            int diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Please guess what number it shows in {InitialTries} tries.");

            int triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                int guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");

                triesLeft--;
            }
            return GameResult.Loss;
        }
    }
}
