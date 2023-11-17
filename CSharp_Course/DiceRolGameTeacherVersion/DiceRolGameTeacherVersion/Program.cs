using DiceRolGameTeacherVersion.Game;

Random random = new Random();
Dice dice = new Dice(random);
GuessingGame guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadKey();

