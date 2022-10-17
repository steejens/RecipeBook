using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.IngredientQueries.GetAllIngredientsByFoodId
{
    public class GetAllIngredientsByFoodIdQuery : IQuery<GetAllIngredientsByFoodIdResponse>
    {
        public GetAllIngredientsByFoodIdQuery(GetAllIngredientsByFoodIdRequest request)
        {
            Request = request;
        }

        public GetAllIngredientsByFoodIdRequest Request { get; set; }

    }
}
