using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.FoodCategoryRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodCategories
{
    public class GetFoodCategoriesQueryHandler : IQueryHandler<GetFoodCategoriesQuery, GetFoodCategoriesResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodCategoryRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetFoodCategoriesQueryHandler(IMapper mapper, IFoodCategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetFoodCategoriesResponse> Handle(GetFoodCategoriesQuery query, CancellationToken cancellationToken)
        {

            var test = _repository.GetAll().ToList();

            var result = _mapper.Map<List<FoodCategory>,List<CategoryConfig>>(test);
            return new GetFoodCategoriesResponse
            {
                Response = result
            };
        }
    }
}
