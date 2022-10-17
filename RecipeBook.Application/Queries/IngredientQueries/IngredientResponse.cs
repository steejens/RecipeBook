namespace RecipeBook.Application.Queries.IngredientQueries
{
    public class IngredientResponse
    {
        public int IngredientId { get; set; }
        public string? Title { get; set; }
        public float KcalPer100g { get; set; }
    }
}
