using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMI.Models
{
    public class NutritionPlan
    {

        public string NutritionName { get; set; }
        public int CalorieOfNutrition { get; set; }
        public string MealType { get; set; }
        public string ServingAmount { get; set; }

    }
}