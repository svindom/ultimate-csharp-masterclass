using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

CookiesRecipesApp cookiesRecipesApp = new CookiesRecipesApp( new RecipesRepository(), new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run("recipes.txt");

Console.ReadKey();

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run(string filePath)
    {
        List<Recipe> allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromtToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count > 0)
        {
            Recipe recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipes.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();
    }
}

public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);
    public void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close the app.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if(allRecipes.Count() > 0)
        {
            Console.WriteLine($"Existing recipes are: {Environment.NewLine}");

            int counter = 1;
            foreach(Recipe recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                counter++;
            }
        }
    }
}


public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}

public class RecipesRepository : IRecipesRepository
{
    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>{new WheatFlour(), new Butter(), new Sugar()}),
            new Recipe(new List<Ingredient>{new CocoaPowder(), new SpeltFlour(), new Cinnamom()})
        };
    }
}