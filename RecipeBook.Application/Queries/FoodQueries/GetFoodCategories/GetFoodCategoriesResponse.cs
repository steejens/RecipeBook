namespace RecipeBook.Application.Queries.FoodQueries.GetFoodCategories
{
    public class GetFoodCategoriesResponse
    {
        public List<CategoryConfig>? Response { get; set; }

    }

    public class CategoryConfig
    {
        public int CatId { get; set; }
        public string Title { get; set; }
    }
}
