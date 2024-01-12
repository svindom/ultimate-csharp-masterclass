GameElements gameElements = new GameElements();
Computer computerPlayer = new Computer(gameElements);
GamePlay gamePlay = new GamePlay(gameElements, computerPlayer);

string userAnswer;

do
{
    GameResults gameResults = gamePlay.Play();
    gamePlay.ReturnResult(gameResults);

    Console.WriteLine("Do you want restart the game? [y/n]");
    userAnswer = Console.ReadLine().ToLower();
    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.WriteLine("Invalid input. Use \'y\' for yes, \'n\' for no");
        userAnswer = Console.ReadLine().ToLower();
    }

}
while (userAnswer == "y");
