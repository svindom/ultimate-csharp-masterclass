namespace CookiesCookbook.Recipes.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override int Id
        {
            get
            {
                return 4;
            }
        }
        public override string Name => "Butter";
        public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}";
    }
}
