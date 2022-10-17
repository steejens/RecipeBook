using System.Data.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.FoodIngredientRepository;
using RecipeBook.DataAccess.Repository.FoodRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.IngredientQueries.GetAllIngredientsByFoodId
{
    public class GetAllIngredientsByFoodIdQueryHandler : IQueryHandler<GetAllIngredientsByFoodIdQuery, GetAllIngredientsByFoodIdResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodIngredientRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetAllIngredientsByFoodIdQueryHandler(IMapper mapper, IFoodIngredientRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetAllIngredientsByFoodIdResponse> Handle(GetAllIngredientsByFoodIdQuery query, CancellationToken cancellationToken)
        {
            var foodId = query.Request.FoodId;
            var ingredients = _repository.FindBy(x => x.FoodRefId == foodId, "Ingredient", "IngredientUnit")
                .GroupBy(x => x.FoodRefId).Select(c => new GetAllIngredientsByFoodIdResponse
                {
                    FoodRefId =  c.Key,
                    Ingredients = _mapper.Map<List<FoodIngredient>, List<IngredientGeneralResponse>>(c.ToList())
                 }).FirstOrDefault();

            return ingredients;
        }
    }
}
