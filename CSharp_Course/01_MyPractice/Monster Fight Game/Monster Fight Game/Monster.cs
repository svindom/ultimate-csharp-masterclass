public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }


    public Monster()
    {
        Health = 100;
    }

    public int Attack()
    {
        Random random = new Random();
        return random.Next(10, 21);
    }
}


