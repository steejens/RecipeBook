using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetAllFoods
{
    public class GetAllFoodQuery : IQuery<GetAllFoodResponse>
    {
        public GetAllFoodQuery(GetAllFoodRequest request)
        {
            Request = request;
        }

        public GetAllFoodRequest Request { get; set; }

    }
}
