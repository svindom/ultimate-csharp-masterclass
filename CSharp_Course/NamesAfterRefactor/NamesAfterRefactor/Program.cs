using NamesAfterRefactor.DataAccess;

Names names = new Names();
string path = new NamesFilePathBuilder().BuildFilePath();
StringsTextualRepository stringsTextualRepository = new StringsTextualRepository();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names");
    List<string> stringsFromFile = stringsTextualRepository.Read(path); 
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist");

    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely nat a valid name");

    Console.WriteLine("Saving names to a file");
    stringsTextualRepository.Write(path, names.All);
}

Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadLine();

