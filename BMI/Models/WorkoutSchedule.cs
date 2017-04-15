using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMI.Models
{
    public class WorkoutSchedule
    {

        public string WorkoutName { get; set; }
        public int SetNumber { get; set; }
        public string RepeatNumber { get; set; }
        public string WorkoutTargetArea { get; set; }

    }
}