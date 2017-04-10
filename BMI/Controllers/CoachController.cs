using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMI.Models;

namespace BMI.Controllers
{
    public class CoachController : Controller
    {
        // GET: Coach
        public ActionResult Calculate()
        {
            return View();
        }
        //GET: Result
        public ActionResult Result(string userWeight, string userHeight, string userAge, string userGender, string userWaist, string userHips, string userForearms, string userWrist, string userTargetWeight)
        {
            UserResult res = new UserResult();
            res.Weight = userWeight;
            res.Height = userHeight;
            res.Age = userAge;
            res.Gender = userGender;
            res.Waist = userWaist;
            res.Hips = userHips;
            res.Forearms = userForearms;
            res.Wrist = userWrist;
            res.TargetWeight = userTargetWeight;

            return View(res);
        }

    }
}