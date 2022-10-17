using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Application.Queries.IngredientQueries.GetAllIngredientsByFoodId;
using RecipeBook.Application.Queries.IngredientQueries.IngredientMeasurementsQueries;

namespace RecipeBook.API.Controllers.Ingredient
{
    public class IngredientController : BaseController
    {

        [Produces("application/json")]
        [HttpGet("FoodIngredients")]
        public async Task<ApiResponse> GetIngredientsAsync([FromQuery] GetAllIngredientsByFoodIdRequest request)
        {
            var result = await Mediator.Send(new GetAllIngredientsByFoodIdQuery(request));
            return new ApiResponse(result);
        }

        [Produces("application/json")]
        [HttpGet ("measurement")]
        public async Task<ApiResponse> GetMeasurementAsync([FromQuery] IngredientMeasurementRequest request)
        {
            var result = await Mediator.Send(new IngredientMeasurementQuery(request));
            return new ApiResponse(result);
        }
    }
}
