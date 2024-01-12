


public class Computer
{
    GameElements _gameElements = new GameElements();

    public Computer(GameElements gameElements)
    {
        _gameElements = gameElements;
    }

    public string GetComputerChoice()
    {
        string computerChoice = _gameElements.GetGameRandomElement();
        return computerChoice;
    }

}
