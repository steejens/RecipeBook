using AutoWrapper;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Queries.IngredientQueries.IngredientMeasurementsQueries
{
    public class IngredientMeasurementResponse
    {
        public int IngredientRefId { get; set; }
        public int UnitRefId { get; set; }
        public float GramPerUnit { get; set; }
        public float KCalPer100g { get; set; }

    }
}
