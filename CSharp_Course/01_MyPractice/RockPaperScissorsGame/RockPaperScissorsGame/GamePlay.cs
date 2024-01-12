


public class GamePlay
{
    private GameElements _gameElements;
    private Computer _computer;

    private string _userChoice;
    private int _userScore;

    private string _computerChoice;
    private int _computerScore;

    private int gameAttempts = 3;
    

    public GamePlay(GameElements gameElements, Computer computer)
    {
        _gameElements = gameElements;
        _computer = computer;
    }

    public GameResults Play()
    {
        ResetGame(); // Reset the game state at the start of each new game.

        string howToPlay = "Enter [r] key to choose \'Rock\', [p] key to choose \'Paper\', [s] key to choose \'Scissors\'";
        
        Console.WriteLine("Hi Player!\nLet's play the game \'Rock, Paper, Scissors\'");
        Console.WriteLine();
        int totalAttemptsMade = 0;

        while (gameAttempts > 0)
        {
            totalAttemptsMade++;
            Console.WriteLine(howToPlay);
            Console.WriteLine();
            Console.WriteLine($"-----------------------------------------------Attempt: {totalAttemptsMade}-----------------------------------------------");
            _computerChoice = _computer.GetComputerChoice();
            _userChoice = Console.ReadLine().ToLower();
            while (_userChoice != "r" && _userChoice != "p" && _userChoice != "s")
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(howToPlay);
                _userChoice = Console.ReadLine().ToLower();
            }
            DetermineGameResult(_userChoice, _computerChoice);
            
            if (_userScore == 2 || _computerScore == 2)
            {
                break; // Break out of the loop if ether player reach 2 points to the score or the computer does 
            }
        }

        if (_userScore > _computerScore)
        {
            return GameResults.Victory;
        }
        else 
        {
            return GameResults.Loss;
        }
    }

    public void ReturnResult(GameResults gameResults)
    {
        if (gameResults == GameResults.Victory)
        {
            Console.WriteLine("You win!");
        }
        else if (gameResults == GameResults.Loss)
        {
            Console.WriteLine("You lose!");
        }  
    }

    public void DetermineGameResult(string userInput, string computerChoice)
    {
        switch (userInput) 
        {
            case "r":
                if (computerChoice == _gameElements.GetGameElement(0))
                {
                    Console.WriteLine("It's TIE!");
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                else if (computerChoice == _gameElements.GetGameElement(1))
                {
                    Console.WriteLine("You LOSE a round!");
                    _computerScore++;
                    gameAttempts--;
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                else if (computerChoice == _gameElements.GetGameElement(2))
                {
                    Console.WriteLine("You WIN a round!");
                    _userScore++;
                    gameAttempts--;
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                break;
            case "p":
                {
                    if (computerChoice == _gameElements.GetGameElement(1))
                    {
                        Console.WriteLine("It's TIE!");
                        Console.WriteLine($"Computer choice: {computerChoice}");
                        Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                        Console.WriteLine();
                    }
                    else if (computerChoice == _gameElements.GetGameElement(2))
                    {
                        Console.WriteLine("You LOSE a round!");
                        _computerScore++;
                        gameAttempts--;
                        Console.WriteLine($"Computer choice: {computerChoice}");
                        Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                        Console.WriteLine();
                    }
                    else if (computerChoice == _gameElements.GetGameElement(0))
                    {
                        Console.WriteLine("You WIN a round!");
                        _userScore++;
                        gameAttempts--;
                        Console.WriteLine($"Computer choice: {computerChoice}");
                        Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                        Console.WriteLine();
                    }
                    break;
                }
            case "s":
                if (computerChoice == _gameElements.GetGameElement(2))
                {
                    Console.WriteLine("It's TIE!");
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                else if (computerChoice == _gameElements.GetGameElement(0))
                {
                    Console.WriteLine("You LOSE a round!");
                    _computerScore++;
                    gameAttempts--;
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                else if (computerChoice == _gameElements.GetGameElement(1))
                {
                    Console.WriteLine("You WIN a round!");
                    _userScore++;
                    gameAttempts--;
                    Console.WriteLine($"Computer choice: {computerChoice}");
                    Console.WriteLine($"Your score: {_userScore}, Computer choice: {_computerScore}");
                    Console.WriteLine();
                }
                break;
        }
    }

    private void ResetGame()
    {
        _userScore = 0;
        _computerScore = 0;
        gameAttempts = 3;
    }
}
