namespace RecipeBook.Application.Queries.IngredientQueries
{
    public class IngredientGeneralResponse
    {
        public IngredientResponse? Ingredient { get; set; }
        public IngredientUnitResponse? Unit { get; set; }
        public float UnitCount { get; set; }
        public bool? IsDeepFried { get; set; }
        public bool? CountCalories { get; set; }

    }
}
