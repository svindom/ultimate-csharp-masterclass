




public class GamePlay
{
    private Boosters _boosters;
    private MyMonster _myMonster;
    private KrocksMonster _krocksMonster;


    private string _myMonsterName;
    private string _krocksMonsterName;

    private bool _isPlayerFirstTurn;

    public GamePlay(MyMonster myMonster, KrocksMonster krocksMonster)
    {
        _myMonster = myMonster;
        _krocksMonster = krocksMonster;
        _myMonsterName = _krocksMonster.Name;
        _krocksMonsterName = _krocksMonster.Name;   

        _boosters = new Boosters(myMonster, krocksMonster);

        _isPlayerFirstTurn = IsYourTurn();
    }


    public GameResult Play()
    {
        int rounds = 0;
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        string playerMonsterNameToAdd = "Enter your monster name:";

        Console.WriteLine("Hi Player! Greetings in the Monsters Fight Arena!");
        while (_myMonsterName == null)
        {
            Console.WriteLine(playerMonsterNameToAdd);
            _myMonsterName = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Checking who attacks first...");

        bool isPlayerTurn = _isPlayerFirstTurn;

        while (_myMonster.Health > 0 && _krocksMonster.Health > 0)
        {
            Thread.Sleep(3000);
            rounds++;
            Console.WriteLine();
            Console.WriteLine($"------------------Round {rounds}------------------");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonster.Health}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonster.Health}");


            if (isPlayerTurn)
            {
                int myMonsterDamage = _myMonster.Attack();
                _krocksMonster.Health -= myMonsterDamage;

                Console.WriteLine();
                Console.WriteLine($"Your {_myMonsterName} is attacking {_krocksMonsterName} with {myMonsterDamage}");
                _boosters.GetBooster();

            }
            else
            {
                int krocksMonsterDamage = _krocksMonster.Attack();
                _myMonster.Health -= krocksMonsterDamage;
                Console.WriteLine();
                Console.WriteLine($"{_krocksMonsterName} is attacking {_myMonsterName} with {krocksMonsterDamage}");
                _boosters.GetKrocksBooster();

            }

            // Update health values after each action
            _myMonster.Health = _boosters.GetMyMonsterHealth();
            _krocksMonster.Health = _boosters.GetKrocksHealth();

            // Alternate turns
            isPlayerTurn = !isPlayerTurn;
        }

        if (_myMonster.Health > _krocksMonster.Health)
        {
            return GameResult.Victory;
        }
        else if (_krocksMonster.Health == _myMonster.Health)
        {
            return GameResult.Draw;
        }
        return GameResult.Defeat;
    }

    public bool IsYourTurn()
    {
        Random random = new Random();
        int definer = random.Next(0, 11);


        // Check if the number is even. If yes it returns true
        bool isPlayerTurn = definer % 2 == 0;

        return isPlayerTurn;
    }

    public void ReturnGameResult(GameResult gameResult)
    {
        if (gameResult == GameResult.Victory)
        {
            Console.WriteLine();
            Console.WriteLine($"YOU WIN! Your {_myMonsterName} defetated {_krocksMonsterName}");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonster.Health}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonster.Health}");
        }
        else if (gameResult == GameResult.Draw)
        {
            Console.WriteLine();
            Console.WriteLine("It's DRAW!");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonster.Health}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonster.Health}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"YOU LOSE! {_krocksMonsterName} defeted your {_myMonsterName}");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonster.Health}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonster.Health}");
        }
    }

    public void ResetGame()
    {
        _myMonster.Health = 100;
        _krocksMonster.Health = 100;

        // Reset other game state variables if necessary
        _myMonsterName = null;
        _isPlayerFirstTurn = IsYourTurn(); // Decide who starts the new game
    }
}


