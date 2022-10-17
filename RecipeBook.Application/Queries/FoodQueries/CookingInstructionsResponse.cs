using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Application.Queries.FoodQueries
{
    public class CookingInstructionsResponse
    {
        public int InstId { get; set; }
        public int FoodRefId { get; set; }
        public string? InstructionStepText { get; set; }
        public int? StepOrder { get; set; }
    }
}
