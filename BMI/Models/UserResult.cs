using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMI.Models
{
    public class UserResult
    {
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Message { get; set; }
        public string TargetWeight { get; set; }
        public int CalorieToBurn { get; set; }
        public string BFResult { get; set; }
        public double FatPerc { get; set; }


    }
}