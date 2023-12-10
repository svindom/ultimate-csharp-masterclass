CookiesRecipesApp cookiesRecipesApp = new CookiesRecipesApp( new RecipesRepository(), new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run();

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

    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromtToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count > 0)
        {
            var recipes = new Recipe(ingredients);
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
}


public interface IRecipesRepository
{

}

public class RecipesRepository : IRecipesRepository
{
}