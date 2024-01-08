Random random = new Random();




Console.ReadKey();

public class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public void Play()
    {
        int diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

        int triesLeft = InitialTries;
        while (triesLeft > 0) 
        {
            int guess = ConsoleReader.ReadInteger("Enter a number: ");
            triesLeft--;
        }
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
    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, DiceSide + 1);
    }
}



