using AutoMapper;
using RecipeBook.Application.Queries.FoodQueries;
using RecipeBook.Application.Queries.IngredientQueries;
using RecipeBook.Application.Queries.IngredientQueries.IngredientMeasurementsQueries;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;
using RecipeBook.Domain.Entities.Ingredients;

namespace RecipeBook.Application.Mapping
{
    public class IngredientMappingProfile : Profile
    {
        public IngredientMappingProfile()
        {
            CreateMap<FoodIngredient, IngredientGeneralResponse>().ForMember(x=>x.Unit, opt=>opt.MapFrom(y=>y.IngredientUnit));
            CreateMap<Ingredient, IngredientResponse>();
            CreateMap<IngredientUnit, IngredientUnitResponse>();
            CreateMap<IngredientMeasurement, IngredientMeasurementResponse>().ForMember(x=>x.KCalPer100g, opt=>opt.MapFrom(y=>y.Ingredient.KcalPer100g));

        }
    }
}
