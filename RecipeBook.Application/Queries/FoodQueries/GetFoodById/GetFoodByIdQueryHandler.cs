using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.FoodRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodById
{
    public class GetFoodByIdQueryHandler : IQueryHandler<GetFoodByIdQuery, GetFoodByIdResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetFoodByIdQueryHandler(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetFoodByIdResponse> Handle(GetFoodByIdQuery query, CancellationToken cancellationToken)
        {
            var foodId = query.Request.FoodId;
            var test = _repository.FindBy(x=>x.FoodId== foodId,"FoodCategory", "FoodType", "DifficultyLevel").FirstOrDefault();

            var result = _mapper.Map<Food,FoodResponse>(test);
            return new GetFoodByIdResponse
            {
                Response = result
            };
        }
    }
}
