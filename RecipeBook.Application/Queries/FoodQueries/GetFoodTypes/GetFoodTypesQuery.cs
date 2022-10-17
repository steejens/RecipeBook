using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodTypes
{
    public class GetFoodTypesQuery : IQuery<GetFoodTypesResponse>
    {
        public GetFoodTypesQuery(GetFoodTypesRequest request)
        {
            Request = request;
        }

        public GetFoodTypesRequest Request { get; set; }

    }
}
