namespace RecipeBook.Application.Queries.FoodQueries.GetFoodTypes
{
    public class GetFoodTypesResponse
    {
        public List<TypeConfig>? Response { get; set; }

    }

    public class TypeConfig
    {
        public int TypeId { get; set; }
        public string Title { get; set; }
    }
}
