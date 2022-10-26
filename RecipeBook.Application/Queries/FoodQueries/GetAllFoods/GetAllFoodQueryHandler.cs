using System.Data.Entity;
using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using RecipeBook.Core.Utilities;
using RecipeBook.DataAccess.Repository.FoodRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.FoodQueries.GetAllFoods
{
    public class GetAllFoodQueryHandler : IQueryHandler<GetAllFoodQuery, GetAllFoodResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetAllFoodQueryHandler(IMapper mapper, IFoodRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<GetAllFoodResponse> Handle(GetAllFoodQuery query, CancellationToken cancellationToken)
        {
            var catId = query.Request.CategoryRefId;
            var typeId = query.Request.TypeRefId;

            Expression<Func<Food, bool>> byCategoriesExpression = c => c.CategoryRefId == catId;
            Expression<Func<Food, bool>> byTypeExpression = c => c.TypeRefId == typeId;
            Expression<Func<Food, bool>> predecate = c =>  true;

            if (catId != null)
            {
                predecate = predecate.And(byCategoriesExpression);
            }
            if (typeId != null)
            {
                predecate = predecate.And(byTypeExpression);
            }

            var test = _repository.FindBy(predecate,"FoodCategory", "FoodType", "DifficultyLevel").ToList();

            var result = _mapper.Map<List<Food>,List<FoodResponse>>(test);
            return new GetAllFoodResponse
            {
                Responses = result
            };
        }
    }
}
