using RecipeBook.Infrastructure.Configurations.Queries;

namespace RecipeBook.Application.Queries.IngredientQueries.IngredientMeasurementsQueries
{
    public class IngredientMeasurementQuery : IQuery<IngredientMeasurementResponse>
    {
        public IngredientMeasurementQuery(IngredientMeasurementRequest request)
        {
            Request = request;
        }

        public IngredientMeasurementRequest Request { get; set; }

    }
}
