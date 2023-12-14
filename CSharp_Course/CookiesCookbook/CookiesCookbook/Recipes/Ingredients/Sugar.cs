namespace CookiesCookbook.Recipes.Ingredients
{
    public class Sugar : Ingredient
    {
        public override int Id
        {
            get
            {
                return 5;
            }
        }
        public override string Name => "Sugar";
    }
}
