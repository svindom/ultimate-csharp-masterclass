


public class GameElements
{
    
    private readonly string[] gameElements;

    public GameElements()
    {
        gameElements = new string[] { "Rock", "Paper", "Scissors" };
        
    }

    public string GetGameElement (int index)
    {

            if (index >= 0 && index < gameElements.Length)
            {
                return gameElements[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range for game elements");
            }


    }

    public string GetGameRandomElement()
    {
        Random random = new Random();
        return gameElements[random.Next(0, gameElements.Length)];
    }
}