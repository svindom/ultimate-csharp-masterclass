MyMonster myMonster = new MyMonster();
KrocksMonster krocksMonster = new KrocksMonster();
Boosters boosters = new Boosters(myMonster, krocksMonster);

GamePlay gamePlay = new GamePlay(myMonster, krocksMonster);

string userAnswer;

do
{
    gamePlay.ResetGame(); // Reset the game before starting a new round
    GameResult gameResult = gamePlay.Play();
    gamePlay.ReturnGameResult(gameResult);


    // ... Code to ask if the player wants to restart ...
    Console.WriteLine("Do you want restart the game? [y/n]");
    userAnswer = Console.ReadLine().ToLower();
    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.WriteLine("Invalid input. Use \'y\' for yes, \'n\' for no");
        userAnswer = Console.ReadLine().ToLower();
    }
}
while (userAnswer == "y");


