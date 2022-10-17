using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodById
{
    public class GetFoodByIdQuery : IQuery<GetFoodByIdResponse>
    {
        public GetFoodByIdQuery(GetFoodByIdRequest request)
        {
            Request = request;
        }

        public GetFoodByIdRequest Request { get; set; }

    }
}
