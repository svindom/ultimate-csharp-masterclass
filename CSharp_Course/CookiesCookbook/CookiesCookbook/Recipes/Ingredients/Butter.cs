namespace CookiesCookbook.Recipes.Ingredients
{
    public class Butter : Ingredient
    {
        public override int Id
        {
            get
            {
                return 3;
            }
        }
        public override string Name => "Butter";
        public override string PreparationInstructions => $"Melt on low heat. {base.PreparationInstructions}";
    }
}
