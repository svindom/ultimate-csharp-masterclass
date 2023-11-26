
//Console.WriteLine("Variable of type cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

List<Ingredient> ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozarella(),
    new TomatoSause()
};

foreach(Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngrediaents(Ingredient ingredient) =>    // check what lambda operator is.
    _ingredients.Add(ingredient);

    public string Describe()
    {
        return $"This is a pizza with {string.Join(", ", _ingredients)}";
    }
}


public class Ingredient
{
    //PROPERTIES
    public virtual string Name { get; } = "Some ingredient";

    //fields
    public int PublicField; // This field is the same as it is in each of derived classes but we can declare different values in each of new instances

    // Methods
    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";
    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredient class.";
    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class."; // I can access the protected method in a derived class but NOT outside else
}

public class Cheddar : Ingredient
{
    // properties
    public override string Name  // public string Name => "Cheddar cheese";
    {
        get
        {
            return "Cheddar cheese";
        }
    }
    public int AgedForMonth { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}

public class TomatoSause : Ingredient
{
    // properties
    public override string Name => "Tomato sause";
    public int TomatosIn100Grams { get; }
}

public class Mozarella : Ingredient
{
    // properties
    public override string Name => "Mozarella";
    public bool isLight { get; }
}
