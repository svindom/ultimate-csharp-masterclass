public class Boosters
{
    MyMonster _myMonster;
    KrocksMonster _krocksMonster;
    private const int Heal = 10;

    // Stateful properties for MyMonster's boosters
    private bool isMyBooster1Used = true;
    private bool isMyBooster2Used = true;
    private bool isMyBooster3Used = true;
    private int myBoosterCounter = 0;

    // Stateful properties for KrocksMonster's boosters
    private bool isKrocksBooster1Used = true;
    private bool isKrocksBooster2Used = true;
    private bool isKrocksBooster3Used = true;
    private int krocksBoosterCounter = 0;

    public Boosters(MyMonster myMonster, KrocksMonster krocksMonster)
    {
        _myMonster = myMonster;
        _krocksMonster = krocksMonster;
    }

    public void GetBooster()
    {
        if (myBoosterCounter < 3)
        {
            GetBoostersInfo();
            string userInput = Console.ReadLine().ToLower();
            Random random = new Random();

            int enemyDamage;
            int myMonsterDamage;

            switch (userInput)
            {
                case "1":
                    if (isMyBooster1Used)
                    {
                        myBoosterCounter++;
                        enemyDamage = random.Next(5, 11);
                        _krocksMonster.Health -= enemyDamage;
                        Console.WriteLine();
                        Console.WriteLine($"Your {_myMonster.Name} additionally attacks Krocks by {enemyDamage}");
                        isMyBooster1Used = false;
                    }
                    break;
                case "2":
                    {
                        if (isMyBooster2Used)
                        {
                            myBoosterCounter++;
                            _myMonster.Health += Heal;
                            Console.WriteLine();
                            Console.WriteLine($"Your {_myMonster.Name} has been healed by {Heal} units");
                            isMyBooster2Used = false;
                        }
                    }
                    break;
                case "3":
                    if (isMyBooster3Used)
                    {
                        myBoosterCounter++;
                        enemyDamage = random.Next(10, 26);
                        myMonsterDamage = random.Next(10, 26);
                        _krocksMonster.Health -= enemyDamage;
                        _myMonster.Health -= myMonsterDamage;
                        Console.WriteLine();
                        Console.WriteLine($"Your {_myMonster.Name} health reduced by {myMonsterDamage}");
                        Console.WriteLine($"Enemy health reduced by {enemyDamage}");
                        isMyBooster3Used = false;
                    }
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
        else
        {
            Console.WriteLine("You have used all boosters");
        }


    }


    public void GetKrocksBooster()
    {
        Random random = new Random();


        int enemyDamage;
        int myMonsterDamage;

        if (krocksBoosterCounter < 3)
        {
            Console.WriteLine();
            Console.WriteLine("Krocks is using a booster:");
            int krocksChoice = random.Next(1, 5);

            switch (krocksChoice)
            {
                case 1:
                    {
                        if (isKrocksBooster1Used)
                        {
                            krocksBoosterCounter++;
                            myMonsterDamage = random.Next(5, 11);
                            _myMonster.Health -= myMonsterDamage;
                            Console.WriteLine();
                            Console.WriteLine($"{_krocksMonster.Name} additionally attacks your {_myMonster.Name} by {myMonsterDamage}");
                            isKrocksBooster1Used = false;
                        }
                        break;
                    }
                case 2:
                    {

                        if (isKrocksBooster2Used)
                        {
                            krocksBoosterCounter++;
                            _krocksMonster.Health += Heal;
                            Console.WriteLine();
                            Console.WriteLine($"{_krocksMonster.Name} has been healed by {Heal} units");
                            isKrocksBooster2Used = false;
                        }
                        break;
                    }
                case 3:
                    {

                        if (isKrocksBooster3Used)
                        {
                            krocksBoosterCounter++;
                            enemyDamage = random.Next(10, 26);
                            myMonsterDamage = random.Next(10, 26);
                            _krocksMonster.Health -= enemyDamage;
                            _myMonster.Health -= myMonsterDamage;
                            Console.WriteLine();
                            Console.WriteLine($"Your {_myMonster.Name} health reduced by {myMonsterDamage}");
                            Console.WriteLine($"Enemy health reduced by {enemyDamage}");
                            isKrocksBooster3Used = false;
                        }
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

    }


    public int GetKrocksHealth()
    {
        return _krocksMonster.Health;
    }

    public int GetMyMonsterHealth()
    {
        return _myMonster.Health;
    }



    public void GetBoostersInfo()
    {
        Console.WriteLine();
        Console.WriteLine("You can additionally use one of the three provided boosters");
        if (isMyBooster1Used)
        {
            Console.WriteLine("Press \'1\' to launch an additional attack on your Enemy, causing damage within a range of 5 to 10 units.");
        }
        if (isMyBooster2Used)
        {
            Console.WriteLine($"Press \'2\' to heal your {_myMonster.Name} by {Heal} units.");

        }
        if (isMyBooster3Used)
        {
            Console.WriteLine($"Press \'3\' to reduce both your {_myMonster.Name} and Krocks health within a range of 10 to 25 units.");
        }
        Console.WriteLine($"Press \'s\' to skip this.");
        Console.WriteLine();
    }
}




