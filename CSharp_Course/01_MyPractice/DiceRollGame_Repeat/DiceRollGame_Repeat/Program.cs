Random random = new Random();
Dice dice = new Dice(random);
GuessingGame guessingGame = new GuessingGame(dice);
string userAnswer;

do
{
    GameResult gameResult = guessingGame.Play();
    guessingGame.PrintResult(gameResult);

    Console.WriteLine();
    Console.WriteLine("Do you want to play again? [y/n]");
    userAnswer = Console.ReadLine().ToLower();
    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.WriteLine("Invalid input. Use \'y\' for yes, 'n' for no");
        userAnswer = Console.ReadLine().ToLower();
    }
}
while (userAnswer == "y");





Console.ReadKey();


public enum GameResult
{
    Victory,
    Loss
}

public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        
        int diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

        int triesLeft = InitialTries;
        while (triesLeft > 0) 
        {
            int guess = ConsoleReader.ReadInteger("Enter a number: ");
            if ( guess == diceRollResult)
            {
                return GameResult.Victory;
            }
            else
            {
                Console.WriteLine("Wrong number.");
            }
            triesLeft--;
        }
        return GameResult.Loss;
    }
    public void PrintResult(GameResult gameResult)
    {
        string message;
        if (gameResult == GameResult.Victory)
        {
            message = $"You win!\n-----------------------------------------------------------\nDice number was: {_dice.DiceNumber}";

        }
        else
        {
            message = $"You lose :(\n-----------------------------------------------------------\nDice number was: {_dice.DiceNumber}";
        }
        Console.WriteLine(message);
    }

}

public static class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}


public class Dice
{
    private readonly Random _random;
    private const int DiceSide = 6;
    public int DiceNumber { get; private set; }
    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        DiceNumber = _random.Next(1, DiceSide + 1);
        return DiceNumber;
    }
}



