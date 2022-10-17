using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodCookingInstructions
{
    public class GetFoodCookingInstructionsQuery : IQuery<GetFoodCookingInstructionsResponse>
    {
        public GetFoodCookingInstructionsQuery(GetFoodCookingInstructionsRequest request)
        {
            Request = request;
        }

        public GetFoodCookingInstructionsRequest Request { get; set; }

    }
}
