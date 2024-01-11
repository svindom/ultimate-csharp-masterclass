Random random = new Random();
Dice dice = new Dice(random);
GuessingGame guessingGame = new GuessingGame(dice);
string userAnswer;

do
{
    GameStages gameStages = guessingGame.Play();
    guessingGame.ReturnResult(gameStages);

    Console.WriteLine("Do you want to play again? [y/n]");
    userAnswer = Console.ReadLine().ToLower();
    while (userAnswer != "y" &&  userAnswer != "n")
    {
        Console.WriteLine("Invalid input. Use \'y\' for yes, 'n' for no");
        userAnswer = Console.ReadLine().ToLower();
    }

}
while (userAnswer == "y");




public enum GameStages
{
    Victory,
    Loss
}


public class GuessingGame
{
    private Dice _dice;
    public const int GameRound = 3;


    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }
    public GameStages Play()
    {
        _dice.Roll();
        int diceResult = _dice.DiceChoice;
        int triesLeft = GameRound;
        Console.WriteLine("Hi Player!\nLet's play a game where you should give away the number that came out of the dice");
        Console.WriteLine();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {GameRound} tries.");
        Console.WriteLine();


        while (triesLeft > 0)
        {
            int userGuess = ConsoleReader.ReturnInt("Enter a number", _dice.DiceSides);
            if (userGuess == diceResult)
            {
                return GameStages.Victory;
            }
            else
            {
                triesLeft--;
                Console.WriteLine("Bad Luck! Wrong number");
                Console.WriteLine($"Attemts left: {triesLeft}");
            }
        }
        return GameStages.Loss;
    }
    public void ReturnResult(GameStages gameStages)
    {
        string message;
        if(gameStages == GameStages.Victory)
        {
            message = $"You win!\n-----------------------------------------------------------\nDice number was: {_dice.DiceChoice}";
        }
        else
        {
            message = $"You lose!\n-----------------------------------------------------------\nDice number was: {_dice.DiceChoice}";
        }
        Console.WriteLine(message);
    }
}


public static class ConsoleReader
{
    public static int ReturnInt(string message, int diceSides)
    {
        int result;
        string userInput;
        do
        {
            Console.WriteLine(message);
            userInput = Console.ReadLine().ToLower();

            while (!int.TryParse(userInput, out result) || result < 1 || result > diceSides)
            {
                Console.WriteLine($"Invalid number. Enter a number from 1 to {diceSides}.");
                Console.WriteLine();
                Console.WriteLine(message);
                userInput = Console.ReadLine().ToLower();
            }
        }
        while (result < 1 || result > diceSides);

        return result;
    }
}



public class Dice
{
    private readonly Random _random;
    public int DiceSides { get; private set; }
    public int DiceChoice { get; private set; }

    public Dice(Random random)
    {
        _random = random;
        DiceSides = 6;
    }

    public int Roll()
    {
        DiceChoice = _random.Next(1, DiceSides + 1);
        return DiceChoice;
    }
}
