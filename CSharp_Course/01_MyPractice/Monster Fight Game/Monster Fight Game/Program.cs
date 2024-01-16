int myMonsterHealth = 100;
int krocksMonsterHealth = 100;

MyMonster myMonster = new MyMonster(myMonsterHealth);
KrocksMonster krocksMonster = new KrocksMonster(krocksMonsterHealth);

GamePlay gamePlay = new GamePlay(myMonster, krocksMonster);

string userAnswer;

do
{
    GameResult gameResult = gamePlay.Play();
    gamePlay.ReturnGameResult(gameResult);

    Console.WriteLine("Do you want restart the game? [y/n]");
    userAnswer = Console.ReadLine().ToLower();
    while (userAnswer != "y" && userAnswer != "n")
    {
        Console.WriteLine("Invalid input. Use \'y\' for yes, \'n\' for no");
        userAnswer = Console.ReadLine().ToLower();
    }
}
while (userAnswer == "y");

Console.ReadKey();

public enum GameResult
{
    Victory,
    Defeat,
    Draw
}

public class GamePlay
{
    private Boosters _boosters;
    private MyMonster _myMonster;
    private KrocksMonster _krocksMonster;
    private int _myMonsterHealth;
    private int _krocksMonsterHealth;
    private string _myMonsterName;
    private string _krocksMonsterName = "Krocks";

    private bool _isPlayerFirstTurn;

    public GamePlay(MyMonster myMonster, KrocksMonster krocksMonster)
    {
        _myMonster = myMonster;
        _myMonsterHealth = myMonster.Health;

        _krocksMonster = krocksMonster;
        _krocksMonsterName = _krocksMonster.Name;
        _krocksMonsterHealth = krocksMonster.Health;

        _boosters = new Boosters(_myMonster, _krocksMonster);

        _isPlayerFirstTurn = IsYourTurn();
    }


    public GameResult Play()
    {
        int rounds = 0;
        string playerMonsterNameToAdd = "Enter your monster name:";

        Console.WriteLine("Hi Player! Greetings in the Monsters Fight Arena!");
        while (_myMonsterName == null )
        {
            Console.WriteLine(playerMonsterNameToAdd);
            _myMonsterName = Console.ReadLine();
        }

        bool isPlayerTurn = _isPlayerFirstTurn;

        while (_myMonsterHealth > 0 && _krocksMonsterHealth > 0)
        {
            rounds++;
            Console.WriteLine($"------------------Round {rounds}------------------");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonsterHealth}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonsterHealth}");


            if (isPlayerTurn)
            {
                int myMonsterDamage = _myMonster.Attack();
                _krocksMonsterHealth -= myMonsterDamage;

                Console.WriteLine();
                Console.WriteLine($"Your {_myMonsterName} is attacking {_krocksMonsterName} with {myMonsterDamage}");
                _boosters.GetBooster();
            }
            else
            {
                int krocksMonsterDamage = _krocksMonster.Attack();
                _myMonsterHealth -= krocksMonsterDamage;
                Console.WriteLine();
                Console.WriteLine($"{_krocksMonsterName} is attacking {_myMonsterName} with {krocksMonsterDamage}");
                _boosters.GetKrocksBooster();
            }

            // Alternate turns
            isPlayerTurn = !isPlayerTurn;
        }

        if (_krocksMonsterHealth == 0)
        {
            return GameResult.Victory;
        }
        else if (_krocksMonsterHealth == _myMonsterHealth)
        {
            return GameResult.Draw;
        }
        return GameResult.Defeat;
    }

    public bool IsYourTurn()
    {
        Random random = new Random();
        int definer = random.Next( 0, 11 );


        // Check if the number is even. If yes it returns true
        bool isPlayerTurn = definer % 2 == 0;

        return isPlayerTurn;
    }

    public void ReturnGameResult(GameResult gameResult)
    {
        if (gameResult == GameResult.Victory)
        {
            Console.WriteLine();
            Console.WriteLine($"You win! Your {_myMonsterName} defetated {_krocksMonsterName}");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonsterHealth}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonsterHealth}");
        }
        else if (gameResult == GameResult.Draw) 
        {
            Console.WriteLine();
            Console.WriteLine("It's draw!");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonsterHealth}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonsterHealth}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"You lose! {_krocksMonsterName} defetated your {_myMonsterName}");
            Console.WriteLine($"Your {_myMonsterName}'s health is: {_myMonsterHealth}");
            Console.WriteLine($"{_krocksMonsterName}'s health is: {_krocksMonsterHealth}");
        }
    }
}

public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }

    
    public Monster(int health)
    { 
        Health = health;
    }
    
    public int Attack()
    {
        Random random = new Random();
        return random.Next(10, 21);
    }
}

public class KrocksMonster : Monster
{
    public KrocksMonster(int health) :base(health)
    {
        // Set the name for KrocksMonster
        Name = "Krocks";
    }
}

public class MyMonster : Monster
{
    public MyMonster(int health) : base(health)
    {

    }
}

public class Boosters
{
    MyMonster _myMonster;
    KrocksMonster _krocksMonster;


    private const int Heal = 10; 
    public Boosters(MyMonster myMonster, KrocksMonster krocksMonster)
    {
        _myMonster = myMonster;
        _krocksMonster = krocksMonster;

    }

    public void GetBooster()
    {
        GetBoostersInfo();
        string userInput = Console.ReadLine().ToLower();
        Random random = new Random();


        int enemyDamage;
        int myMonsterDamage;
        switch (userInput) 
        {
            case "1":
                enemyDamage = random.Next(5, 11);
                _krocksMonster.Health -= enemyDamage;
                Console.WriteLine();
                Console.WriteLine($"Your {_myMonster.Name} additionally attacks Krocks by {enemyDamage}");
                break;
            case "2":
                _myMonster.Health += Heal;
                Console.WriteLine();
                Console.WriteLine($"Your {_myMonster.Name} has been healed by {Heal} units");
                break;
            case "3":
                enemyDamage = random.Next(10, 26);
                myMonsterDamage = random.Next(10, 26);
                _krocksMonster.Health -= enemyDamage;
                _myMonster.Health -= myMonsterDamage;
                Console.WriteLine();
                Console.WriteLine($"Your {_myMonster.Name} health reduced by {myMonsterDamage}");
                Console.WriteLine($"Enemy health reduced by {enemyDamage}");
                break;
            case "s":
                {
                    break;
                }
            default:
                {
                    while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "s")
                    {
                        Console.WriteLine("Invalid input! Enter \'1\' or \'2\' or \'3\' or \'s\'");
                        userInput = Console.ReadLine().ToLower();
                    }
                    break;
                }
        }
    }

   public void GetKrocksBooster()
    {
        Random random = new Random();
        int krocksChoice = random.Next(1, 5);

        int enemyDamage;
        int myMonsterDamage;

        switch (krocksChoice) 
        {
            case 1:
                {
                    myMonsterDamage = random.Next(5, 11);
                    _myMonster.Health -= myMonsterDamage;
                    Console.WriteLine();
                    Console.WriteLine($"{_krocksMonster.Name} additionally attacks your {_myMonster.Name} by {myMonsterDamage}");
                    break;
                }
            case 2: 
                {
                    _krocksMonster.Health += Heal;
                    Console.WriteLine();
                    Console.WriteLine($"{_krocksMonster.Name} has been healed by {Heal} units");
                    break;
                }
            case 3:
                {
                    enemyDamage = random.Next(10, 26);
                    myMonsterDamage = random.Next(10, 26);
                    _krocksMonster.Health -= enemyDamage;
                    _myMonster.Health -= myMonsterDamage;
                    Console.WriteLine();
                    Console.WriteLine($"Your {_myMonster.Name} health reduced by {myMonsterDamage}");
                    Console.WriteLine($"Enemy health reduced by {enemyDamage}");
                    break;
                }
            case 4: 
                {
                    Console.WriteLine();
                    Console.WriteLine($"{_krocksMonster.Name} is skiping to use a booster");
                    break;
                }
         }
    }

    public void GetBoostersInfo()
    {
        Console.WriteLine("You can additionally use one of the three provided boosters");
        Console.WriteLine("Press \'1\' to launch an additional attack on your Enemy, causing damage within a range of 5 to 10 units.");
        Console.WriteLine($"Press \'2\' to heal your {_myMonster.Name} by {Heal} units.");
        Console.WriteLine($"Press \'3\' to reduce both your {_myMonster.Name} and Krocks health within a range of 10 to 25 units.");
        Console.WriteLine($"Press \'s\' to skip this.");
        Console.WriteLine();
    }
}


