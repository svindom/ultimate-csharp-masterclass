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
    //int computerRandomNumber = GetRandomValue();
    //int userGuessTwo = 0;
    //bool isCorrectGuess = false;

    //for (int turn = 0; turn <=3; turn++)
    //{
    //    int userGuess = ValidateUserInput();
    //    Console.WriteLine($"Attempt {turn + 1}/3");

    //    if (userGuess == computerRandomNumber)
    //    {
    //        isCorrectGuess = true;
    //        userGuess = userGuessTwo;

            
    //    }
    //    else if (turn < 3) 
    //    {
    //        Console.WriteLine("Ouch! You guessed wrong");
    //        Console.WriteLine("---------------------------------------------------------");
    //    }
    //}

    //if (isCorrectGuess)
    //{
    //    Console.WriteLine("Hooray! You win!");
    //    Console.WriteLine("---------------------------------------------------------");
    //    Console.WriteLine($"Your guess was: {userGuess}");
    //    Console.WriteLine($"The number on the dice was: {computerRandomNumber}");
    //}
    //else
    //{
    //    Console.WriteLine("Oh noooo, my dear looser. You have lost!");
    //    Console.WriteLine($"Your guess was: {userGuess}");
    //    Console.WriteLine($"The number on the dice was: {computerRandomNumber}");
    //}
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
