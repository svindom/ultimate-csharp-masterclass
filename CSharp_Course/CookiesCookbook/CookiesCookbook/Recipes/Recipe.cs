﻿namespace CookiesCookbook.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }

        public Recipe(IEnumerable<Ingredient> ingredients) 
        {
            Ingredients = ingredients;
        }

    }

    public abstract class Ingredient
    {

    }
}
