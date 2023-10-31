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
    Console.WriteLine();

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
            RemoveTODO();
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
            Console.WriteLine("The description cannot be empty.");
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

void RemoveTODO()
{
    if (myToDo.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet");
        return;
    }
    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Please choose the index of a TODO you want to remove.");
        SeeAllTODO();
        string userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("The description cannot be empty.");
            continue;
        }
        if (int.TryParse(userInput, out int index) && index >=1 && index<= myToDo.Count)
        {
            int indexToBeRemoved = index -1;
            string aTODOtoBeRemoved = myToDo[indexToBeRemoved];
            myToDo.Remove(aTODOtoBeRemoved);
            isIndexValid = true;
            Console.WriteLine($"Your {aTODOtoBeRemoved} has been removed");
        }
        else
        {
            Console.WriteLine("The given index is not valid");
        }
    }


}



















