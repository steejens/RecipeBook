using AutoMapper;
using Microsoft.AspNetCore.Http;
using RecipeBook.DataAccess.Repository.IngredientMeasurementRepository;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Ingredients;
using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.IngredientQueries.IngredientMeasurementsQueries
{
    public class IngredientMeasurementQueryHandler : IQueryHandler<IngredientMeasurementQuery, IngredientMeasurementResponse>
    {
        private readonly IMapper _mapper;
        private readonly IIngredientMeasurementRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IngredientMeasurementQueryHandler(IMapper mapper, IIngredientMeasurementRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<IngredientMeasurementResponse> Handle(IngredientMeasurementQuery query, CancellationToken cancellationToken)
        {
            var ingId = query.Request.IngredientRefId;
            var unitId = query.Request.UnitRefId;
            var test = _repository.FindBy(x=>x.IngredientRefId == ingId && x.UnitRefId == unitId,
                "Ingredient").FirstOrDefault();
            var result = _mapper.Map<IngredientMeasurement, IngredientMeasurementResponse>(test);

            return result;
        }
    }
}
