using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.FoodCategoryRepository;
using RecipeBook.DataAccess.Repository.FoodTypeRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodTypes
{
    public class GetFoodTypesQueryHandler : IQueryHandler<GetFoodTypesQuery, GetFoodTypesResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodTypeRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetFoodTypesQueryHandler(IMapper mapper, IFoodTypeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetFoodTypesResponse> Handle(GetFoodTypesQuery query, CancellationToken cancellationToken)
        {

            var test = _repository.GetAll().ToList();

            var result = _mapper.Map<List<FoodType>,List<TypeConfig>>(test);
            return new GetFoodTypesResponse
            {
                Response = result
            };
        }
    }
}
