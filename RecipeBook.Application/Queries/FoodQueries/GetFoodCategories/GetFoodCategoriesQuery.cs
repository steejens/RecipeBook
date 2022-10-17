using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodCategories
{
    public class GetFoodCategoriesQuery : IQuery<GetFoodCategoriesResponse>
    {
        public GetFoodCategoriesQuery(GetFoodCategoriesRequest request)
        {
            Request = request;
        }

        public GetFoodCategoriesRequest Request { get; set; }

    }
}
