Pizza pizza = new Pizza();
pizza.AddIngrediaents(new Chedar());
pizza.AddIngrediaents(new Mozarella());
pizza.AddIngrediaents(new TomatoSause());

Console.WriteLine(pizza.Describe());
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

}

public class Chedar : Ingredient
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