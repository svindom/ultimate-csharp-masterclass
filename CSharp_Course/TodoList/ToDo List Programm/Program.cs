List<string> todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;

while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Press \"S\" to see all TODOs");
    Console.WriteLine("Press \"A\" to add a new TODO");
    Console.WriteLine("Press \"R\" to remove a TODO");
    Console.WriteLine("Press \"E\" to exit the programm");
    string userChoice = Console.ReadLine().ToUpper();

    switch (userChoice)
    {
        case "E":
            Console.WriteLine("Exit");
            shallExit = true;
            break;
        case "S":
            SeeAllToDos();
            break;
        case "A":
            AddToDo();
            break;
        case "R":
            RemoveToDo();
            break;
        default:
            Console.WriteLine("Invalid choise");
            break;
    }
}
Console.ReadKey();

void SeeAllToDos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine("Your TODO List:");
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }

}


void AddToDo()
{
    bool isValidDescription = false;

    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description");
        string descriptionToDo = Console.ReadLine();

        if (descriptionToDo == "")
        {
            Console.WriteLine("The discription cannot be empty");
        }
        else if (todos.Contains(descriptionToDo))
        {
            Console.WriteLine("The description must be unique");
        }
        else
        {
            isValidDescription = true;
            todos.Add(descriptionToDo);
        }
    }
}



void RemoveToDo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }
    bool isIndexValid = false;
    while (!isIndexValid)
    {
        Console.WriteLine("Select the index of the TODO you want to remove");
        SeeAllToDos();
        string userInput = Console.ReadLine();

        if (userInput == "")
        {
            Console.WriteLine("The discription cannot be empty");
            continue;
        }
        if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
        {
            var indexOfToDo = index - 1;
            var toBeRemoved = todos[indexOfToDo];
            todos.RemoveAt(indexOfToDo);
            isIndexValid = true;
            Console.WriteLine("TODO removed: " + toBeRemoved);
        }
        else
        {
            Console.WriteLine("The given index is not valid");
        }
    }
}

static void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet");
}















