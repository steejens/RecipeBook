using AutoWrapper.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Application.Queries.FoodQueries.GetAllFoods;
using RecipeBook.Application.Queries.FoodQueries.GetFoodById;
using RecipeBook.Application.Queries.FoodQueries.GetFoodCategories;
using RecipeBook.Application.Queries.FoodQueries.GetFoodCookingInstructions;
using RecipeBook.Application.Queries.FoodQueries.GetFoodTypes;

namespace RecipeBook.API.Controllers.Food
{
    public class FoodController : BaseController
    {
        [Produces("application/json")]
        [HttpGet ("category")]
        public async Task<ApiResponse> GetCategoriesAsync([FromQuery] GetFoodCategoriesRequest request)
        {
            var result = await Mediator.Send(new GetFoodCategoriesQuery(request));
            return new ApiResponse(result.Response);
        }

        [Produces("application/json")]
        [HttpGet("type")]
        public async Task<ApiResponse> GetTypesAsync([FromQuery] GetFoodTypesRequest request)
        {
            var result = await Mediator.Send(new GetFoodTypesQuery(request));
            return new ApiResponse(result.Response);
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<ApiResponse> GetFoodAsync([FromQuery] GetAllFoodRequest request)
        {
            var result = await Mediator.Send(new GetAllFoodQuery(request));
            return new ApiResponse(result.Responses);
        }
        [Produces("application/json")]
        [HttpGet ("foodById")]
        public async Task<ApiResponse> GetFoodByIdAsync([FromQuery] GetFoodByIdRequest request)
        {
            var result = await Mediator.Send(new GetFoodByIdQuery(request));
            return new ApiResponse(result.Response);
        }

        [Produces("application/json")]
        [HttpGet ("CookingInstructions")]
        public async Task<ApiResponse> GetFoodCookingInstructionsAsync([FromQuery] GetFoodCookingInstructionsRequest request)
        {
            var result = await Mediator.Send(new GetFoodCookingInstructionsQuery(request));
            return new ApiResponse(result);
        }


    }
}
