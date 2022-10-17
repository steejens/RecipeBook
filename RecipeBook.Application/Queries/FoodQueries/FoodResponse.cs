using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBook.Domain.Entities;

namespace RecipeBook.Application.Queries.FoodQueries
{
    public class FoodResponse
    {
        public int FoodId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CoverPhoto { get; set; }
        public int? PreparationTime { get; set; }
        public int? CookingTime { get; set; }
        public int? ServingFor { get; set; }
        public DifficultyResponse? Level { get; set; }
        public CategoryResponse? FoodCategory { get; set; }
        public TypeResponse? FoodType { get; set; }
    }
}
