namespace RecipeBook.Application.Queries.IngredientQueries.GetAllIngredientsByFoodId
{
    public class GetAllIngredientsByFoodIdResponse
    {
        public int FoodRefId { get; set; }
        public List<IngredientGeneralResponse>? Ingredients { get; set; }

    }
}
