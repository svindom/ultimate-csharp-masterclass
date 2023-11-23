//Pizza pizza = new Pizza();
//pizza.AddIngrediaents(new Chedar());
//pizza.AddIngrediaents(new Mozarella());
//pizza.AddIngrediaents(new TomatoSause());

//Console.WriteLine(pizza.Describe());


Ingredient ingredient = new Ingredient();
ingredient.PublicField = 10;

Cheddar cheddar = new Cheddar();
cheddar.PublicField = 20;

Console.WriteLine($"Value in ingredient: {ingredient.PublicField}");
Console.WriteLine($"Value in cheddar: {cheddar.PublicField}");

Console.WriteLine(cheddar.PublicMethod());



Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngrediaents (Ingredient ingredient) =>    // check what lambda operator is.
    _ingredients.Add(ingredient);
    
    public string Describe ()
    {
        return $"This is a pizza with {string.Join(", ", _ingredients)}";
    }
}


public class Ingredient
{
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
    public string Name  // public string Name => "Cheddar cheese";
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
    public string Name => "Tomato sause";
    public int TomatosIn100Grams { get; }
}

public class Mozarella : Ingredient
{
    // properties
    public string Name => "Mozarella";
    public bool isLight { get; }
}