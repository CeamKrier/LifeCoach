using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMI.Models
{
    public class EstimatedCalories
    {

        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public int Sedentary { get; set; }
        public int ModeratelyActive { get; set; }
        public int Active { get; set; }

    }
}