using AutoMapper;
using RecipeBook.Application.Queries.FoodQueries;
using RecipeBook.Application.Queries.FoodQueries.GetFoodCategories;
using RecipeBook.Application.Queries.FoodQueries.GetFoodTypes;
using RecipeBook.Domain.Entities;
using RecipeBook.Domain.Entities.Food;

namespace RecipeBook.Application.Mapping
{
    public class FoodMappingProfile : Profile
    {
        public FoodMappingProfile()
        {
            CreateMap<Food, FoodResponse>().ForMember(x=>x.Level,opt=>opt.MapFrom(z=>z.DifficultyLevel));
            CreateMap<FoodCategory, CategoryResponse>();
            CreateMap<FoodType, TypeResponse>();
            CreateMap<DifficultyLevel, DifficultyResponse>();
            CreateMap<CookingInstruction, CookingInstructionsResponse>();
            CreateMap<FoodCategory, CategoryConfig>();
            CreateMap<FoodType, TypeConfig>();

        }
    }
}
