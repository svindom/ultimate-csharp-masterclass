Names names = new Names();
string path = names.BuildFilePath();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist");

    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely nat a valid name");

    Console.WriteLine("Saving names to a file");
    names.WriteToTextFile();
}

Console.WriteLine(names.Format());
Console.ReadLine();




class NamesValidator
{
    public bool IsValidName(string name)
    {
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    }
}

class Names
{
    private List<string> _names { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddName(string name)
    {
        if (_namesValidator.IsValidName(name))
        {
            _names.Add(name);
        }
    }

    public void ReadFromTextFile()
    {
        string fileContents = File.ReadAllText(BuildFilePath());
        List<string> namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach (string name in namesFromFile) 
        {
            AddName(name);
        }
    }

    public void WriteToTextFile() 
    {
        File.WriteAllText(BuildFilePath(), Format());
    }

    public string BuildFilePath()
    {
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, _names);
    }
}