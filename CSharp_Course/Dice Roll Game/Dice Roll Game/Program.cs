Console.WriteLine("Hey! Let's play a Dice game!");
Console.WriteLine("I will roll a dice and you should guess the number. You have only 3 attempts");
Console.WriteLine();

PlayDiceGame();

void PlayDiceGame()
{
    string userAnswer;
    do
    {
        PlayThreeAttempts();
        Console.WriteLine();
        Console.WriteLine("Do you want to play again?");
        Console.WriteLine("Press 'Y' to continue or any other key to quit.");
        userAnswer = Console.ReadLine().ToLower();
    }
    while (userAnswer == "y");
}

void PlayThreeAttempts()
{
    int computerRandomNumber = GetRandomValue();

    for (int i = 0; i < 3; i++)
    {
        int userGuess = ValidateUserInput();
        Console.WriteLine($"Attempt {i + 1}/3");

        if (userGuess == computerRandomNumber)
        {
            Console.WriteLine("Hooray! You win!");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Your guess was: {userGuess}");
            Console.WriteLine($"The nubmber on a dice was: {computerRandomNumber}");
            return;
        }
        else if (i < 3)
        {
            Console.WriteLine("Ouch! You guessed wrong");
            Console.WriteLine("---------------------------------------------------------");
        }
        else if (i == 3)
        {
            Console.WriteLine("Oh noooo, my dear looser. You have loose!");
            Console.WriteLine($"Your guess was: {userGuess}");
            Console.WriteLine($"The nubmber on a dice was: {computerRandomNumber}");
        }
    }
}

int GetRandomValue()
{
    int[] diceNumber = new int[6] { 1, 2, 3, 4, 5, 6 };
    Random random = new Random();
    int computerMove = diceNumber[random.Next(0, diceNumber.Length)];
    return computerMove;
}

int ValidateUserInput()
{
    bool isValidInput = false;
    int userInputToInt = 0;

    while (!isValidInput)
    {
        Console.WriteLine("Choose one number from 1 to 6");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out userInputToInt))
        {
            if (userInputToInt >= 1 && userInputToInt <= 6)
            {
                isValidInput = true;

            }
            else
            {
                Console.WriteLine("Not valid number! Please try again!");
                Console.WriteLine("---------------------------------------------------------");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number");
            Console.WriteLine("---------------------------------------------------------");
        }
    }
    return userInputToInt;
}
