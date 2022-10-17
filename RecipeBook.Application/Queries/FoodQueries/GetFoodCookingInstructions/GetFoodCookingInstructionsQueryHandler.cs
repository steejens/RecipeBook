using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.CookingInstructionsRepository;
using RecipeBook.DataAccess.Repository.FoodRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetFoodCookingInstructions
{
    public class GetFoodCookingInstructionsQueryHandler : IQueryHandler<GetFoodCookingInstructionsQuery, GetFoodCookingInstructionsResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICookingInstructionsRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetFoodCookingInstructionsQueryHandler(IMapper mapper, ICookingInstructionsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetFoodCookingInstructionsResponse> Handle(GetFoodCookingInstructionsQuery query, CancellationToken cancellationToken)
        {
            var foodRefId = query.Request.FoodRefId;
            var test = _repository.FindBy(x=>x.FoodRefId == foodRefId).ToList();

            var result = _mapper.Map<List<CookingInstruction>,List<CookingInstructionsResponse>>(test);
            return new GetFoodCookingInstructionsResponse
            {
                Response = result
            };
        }
    }
}
