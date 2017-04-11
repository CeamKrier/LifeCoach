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
        public ActionResult Result(string userWeight, string userHeight, string userAge, string userGender, string userTargetWeight)
        {
            UserResult res = new UserResult();
            res.Weight = userWeight;
            res.Height = userHeight;
            res.Age = userAge;
            res.Gender = userGender;
            
            res.TargetWeight = userTargetWeight;

            double BFP=0.0;

            int kgDeficit = Convert.ToInt16(userWeight)-Convert.ToInt16(userTargetWeight);
            
            if (userGender.Equals("Female"))
            {
                // double f1 = (Convert.ToInt32(userWeight) * 0.732) + 8.987;
                // double f2 = (Convert.ToInt32(userWrist) / 3.140);
                // double f3 = (Convert.ToInt32(userWaist) * 0.157);
                // double f4 = (Convert.ToInt32(userHips)*0.249);
                // double f5 = (Convert.ToInt32(userForearms)*0.434);
                //// double f6 = (0.23*Convert.ToInt16(userAge));

                // double leanBodyMass = f1 + f2 - f3 - f4 + f5;

                // double bodyFatWeight = (Convert.ToInt32(userWeight) - leanBodyMass);

                // BFP = (bodyFatWeight * 100) / (Convert.ToInt32(userWeight));


                //(1.20 x BMI) + (0.23 x age) – 5.4

                double height = Convert.ToDouble(userHeight) / 100;

                double bmi = (Convert.ToInt16(userWeight)) / (height * height);

                BFP = (1.20 * bmi) + (0.23 * Convert.ToInt16(userAge)) - 5.4;


                if (BFP <= 13.0)
                {
                    res.BFResult = "Essential Fat";
                }
                else if (BFP > 14.0 && BFP <= 20.0)
                {
                    res.BFResult = "Athletes";
                }
                else if (BFP > 20.0 && BFP <= 24.0)
                {
                    res.BFResult = "Fitness";
                }
                else if (BFP > 24.0 && BFP <= 31.0)
                {
                    res.BFResult = "Average";
                }
                else if (BFP >= 31.0)
                {
                    res.BFResult = "Obese";
                }

                

            }

            else if (userGender.Equals("Male"))
            {
                //double f1 = (Convert.ToInt32(userWeight) * 1.082) + 94.42;
                //double f2 = (Convert.ToInt32(userWaist) * 4.15);

                //double leanBodyMass = (f1 - f2);

                //double bodyFatWeight = (Convert.ToInt32(userWeight) - leanBodyMass);

                //BFP = (bodyFatWeight * 100) / (Convert.ToInt32(userWeight));


                double height = Convert.ToDouble(userHeight)/100;

                double bmi = (Convert.ToInt16(userWeight)) / (height * height);

                BFP = (1.20 * bmi) + (0.23 * Convert.ToInt16(userAge)) - 10.8 - 5.4;

                if (BFP <= 5.0)
                {
                    res.BFResult = "Essential Fat";
                }
                else if ( BFP > 5.0 && BFP <= 13.0 )
                {
                    res.BFResult = "Athletes";
                }
                else if (BFP > 13.0 && BFP <= 17.0)
                {
                    res.BFResult = "Fitness";
                }
                else if (BFP>17.0 && BFP<=24.0)
                {
                    res.BFResult = "Average";
                }
                else if (BFP>=25.0)
                {
                    res.BFResult = "Obese";
                }
            }
            
            res.FatPerc = Math.Round(BFP,2);

            res.CalorieToBurn = 7860 * Math.Abs(kgDeficit);

            if (Convert.ToInt16(userWeight)<Convert.ToInt16(userTargetWeight))
            {
                res.Message = "You need to gain "+res.CalorieToBurn;
            }
            else if (Convert.ToInt16(userWeight) > Convert.ToInt16(userTargetWeight))
            {
                res.Message = "You need to burn " + res.CalorieToBurn;
            }
            //7860 cal for per kg
            
            return View(res);
        }

    }
}