using System.Reflection.Metadata.Ecma335;

List<string> myToDo = new List<string>();
Console.WriteLine("Hello!");

bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("---------------------------------------------------------------");
    Console.WriteLine("Press \'S\' to see all TODO's");
    Console.WriteLine("Press \'A\' to add a new TODO");
    Console.WriteLine("Press \'R\' to remove a TODO");
    Console.WriteLine("Press \'E\' to exit the program");

    string userInput = Console.ReadLine().ToUpper();

    switch (userInput)
    {
        case "S":
            SeeAllTODO();
            break;
        case "A":
            AddNewTODO();
            break;
        case "R":
            Console.WriteLine("To Remove a TODO");
            break;
        case "E":
            Console.WriteLine("Tap any key to close");
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }

}

Console.ReadKey();

void SeeAllTODO()
{
    if (myToDo.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet");
        return;
    }
    for (int i = 0; i < myToDo.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {myToDo[i]}");
    }
}

void AddNewTODO()
{
    bool ifAddedTODO = false;

    while (!ifAddedTODO)
    {
        Console.WriteLine("Please add a new TODO");
        string addNewTODO = Console.ReadLine();

        if (addNewTODO == "")
        {
            Console.WriteLine("The discription cannot be empty.");
            continue;
        }
        else if (myToDo.Contains(addNewTODO))
        {
            Console.WriteLine("You already have this TODO");
        }
        else 
        {
            myToDo.Add(addNewTODO);
            ifAddedTODO = true;
        }
    }

   

}












