

Console.ReadKey();

public enum GameResult
{
    Victory,
    Defeat,
    Draw
}

public class KrocksMonster
{
    public string Name { get; private set; }
    public int Health { get; set; }

    public KrocksMonster (int health)
    {
        Name = "Krocks";
        Health = health;
    }
    public int Attack()
    {
        Random random = new Random();
        return random.Next(10, 21);
    }
}

public class MyMonster
{
    public string Name { get; set; }
    public int Health { get; set; }

    public MyMonster(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public int Attack()
    {
        Random random = new Random();
        return random.Next(10, 21);
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

    public void GetBooster(string userInput)
    {
        GetBoostersInfo();
        userInput = Console.ReadLine().ToLower();
        Random random = new Random();


        int enemyDamage;
        int myMonsterDamage;
        switch (userInput) 
        {
            case "1":
                enemyDamage = random.Next(5, 11);
                _krocksMonster.Health -= enemyDamage;
                Console.WriteLine($"Your {_myMonster.Name} additionally attacks Krocks by {enemyDamage}");
                break;
            case "2":
                _myMonster.Health += Heal;
                Console.WriteLine($"Your {_myMonster.Name} has been healed by {Heal} units");
                break;
            case "3":
                enemyDamage = random.Next(10, 26);
                myMonsterDamage = random.Next(10, 26);
                _krocksMonster.Health -= enemyDamage;
                _myMonster.Health -= myMonsterDamage;
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

   

    public void GetBoostersInfo()
    {
        Console.WriteLine("You can additionally use one of the three provided boosters");
        Console.WriteLine("Press \'1\' to launch an additional attack on your Enemy, causing damage withina range of 5 to 10 units.");
        Console.WriteLine($"Press \'2\' to heal your {_myMonster.Name} by {Heal} units.");
        Console.WriteLine($"Press \'3\' to reduce both your {_myMonster.Name} and Krocks health within a range of 10 to 25 units.");
        Console.WriteLine($"Press \'s\' to skip this.");
    }
}


