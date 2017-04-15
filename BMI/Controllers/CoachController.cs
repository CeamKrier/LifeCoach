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
        public ActionResult Result(string userWeight, string userHeight, string userAge, string userGender, string userTargetWeight, string userActivityLevel)
        {

            //LinkedList<NutritionPlan> nutritionList = new LinkedList<NutritionPlan>();

            //LinkedList<EstimatedCalories> estimatedCalories = new LinkedList<EstimatedCalories>();

            EstimatedCalories upToTen = new EstimatedCalories();
            upToTen.MaxAge = 10;
            upToTen.MinAge = 2;
            upToTen.Sedentary = 1200;
            upToTen.ModeratelyActive = 1400;
            upToTen.Active = 1650;

            //estimatedCalories.AddLast(upToTen);

            EstimatedCalories upToTwenty = new EstimatedCalories();
            upToTwenty.MaxAge = 20;
            upToTwenty.MinAge = 11;
            upToTwenty.Sedentary = 2200;
            upToTwenty.ModeratelyActive = 2530;
            upToTwenty.Active = 2870;

            //estimatedCalories.AddLast(upToTwenty);

            EstimatedCalories upToThirty = new EstimatedCalories();
            upToThirty.MaxAge = 30;
            upToThirty.MinAge = 21;
            upToThirty.Sedentary = 2150;
            upToThirty.ModeratelyActive = 2400;
            upToThirty.Active = 2700;

            //estimatedCalories.AddLast(upToThirty);

            EstimatedCalories upToFourtyFive = new EstimatedCalories();
            upToFourtyFive.MaxAge = 45;
            upToFourtyFive.MinAge = 31;
            upToFourtyFive.Sedentary = 2100;
            upToFourtyFive.ModeratelyActive = 2300;
            upToFourtyFive.Active = 2530;

            //estimatedCalories.AddLast(upToFourtyFive);

            EstimatedCalories upToSixty = new EstimatedCalories();
            upToSixty.MaxAge = 60;
            upToSixty.MinAge = 46;
            upToSixty.Sedentary = 1930;
            upToSixty.ModeratelyActive = 2130;
            upToSixty.Active = 2460;

            //estimatedCalories.AddLast(upToSixty);

            EstimatedCalories infinityAndBeyond = new EstimatedCalories();
            infinityAndBeyond.MinAge = 61;
            infinityAndBeyond.Sedentary = 1800;
            infinityAndBeyond.ModeratelyActive = 2025;
            infinityAndBeyond.Active = 2400;

            //estimatedCalories.AddLast(infinityAndBeyond);


            LinkedList<WorkoutSchedule> workoutList = new LinkedList<WorkoutSchedule>();

            WorkoutSchedule Back_Squat = new WorkoutSchedule();
            Back_Squat.WorkoutName = "Back Squat";
            Back_Squat.SetNumber = 4;
            Back_Squat.RepeatNumber = "8";
            Back_Squat.WorkoutTargetArea = "Abs & Legs";

            workoutList.AddLast(Back_Squat);
            

            WorkoutSchedule Barbell_Lunge = new WorkoutSchedule();
            Barbell_Lunge.WorkoutName = "Barbell Lunge";
            Barbell_Lunge.SetNumber = 4;
            Barbell_Lunge.RepeatNumber = "12";
            Barbell_Lunge.WorkoutTargetArea = "Abs & Legs";

            workoutList.AddLast(Barbell_Lunge);

            WorkoutSchedule Dumbell_Press = new WorkoutSchedule();
            Dumbell_Press.WorkoutName = "Dumbbell Bench Press";
            Dumbell_Press.SetNumber = 2;
            Dumbell_Press.RepeatNumber = "12";
            Dumbell_Press.WorkoutTargetArea = "Chest & Triceps";

            workoutList.AddLast(Dumbell_Press);

            WorkoutSchedule Double_Crunch = new WorkoutSchedule();
            Double_Crunch.WorkoutName = "Double Crunch";
            Double_Crunch.SetNumber = 4;
            Double_Crunch.RepeatNumber = "20";
            Double_Crunch.WorkoutTargetArea = "Shoulders & Traps";

            workoutList.AddLast(Double_Crunch);

            WorkoutSchedule Barbell_Deadlift = new WorkoutSchedule();
            Barbell_Deadlift.WorkoutName = "Barbell Deadlift";
            Barbell_Deadlift.SetNumber = 4;
            Barbell_Deadlift.RepeatNumber = "8";
            Barbell_Deadlift.WorkoutTargetArea = "Back & Biceps";

            workoutList.AddLast(Barbell_Deadlift);
            





            UserResult res = new UserResult();
            res.Weight = userWeight;
            res.Height = userHeight;
            res.Age = userAge;
            res.Gender = userGender;
            res.TargetWeight = userTargetWeight;
            res.UserActivityLevel = userActivityLevel;


            



            

           

           
            
            
            //Estimated calorie consumption
            if (Convert.ToInt16(userAge) < 11)
            {
                res.EstimatedCalories = upToTen;
            }
            else if (Convert.ToInt16(userAge) > 10 && Convert.ToInt16(userAge) < 21)
            {
                res.EstimatedCalories = upToTwenty;
            }
            else if (Convert.ToInt16(userAge) > 20 && Convert.ToInt16(userAge) < 31)
            {
                res.EstimatedCalories = upToThirty;
            }
            else if (Convert.ToInt16(userAge) > 30 && Convert.ToInt16(userAge) < 46)
            {
                res.EstimatedCalories = upToFourtyFive;
            }
            else if (Convert.ToInt16(userAge) > 45 && Convert.ToInt16(userAge) < 60)
            {
                res.EstimatedCalories = upToSixty;
            }
            else
            {
                res.EstimatedCalories = infinityAndBeyond;
            }


            double BFP = 0.0;

            int kgDeficit = Convert.ToInt16(userWeight) - Convert.ToInt16(userTargetWeight);



            if (userGender.Equals("Female"))
            {

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


                double height = Convert.ToDouble(userHeight) / 100;

                double bmi = (Convert.ToInt16(userWeight)) / (height * height);

                BFP = (1.20 * bmi) + (0.23 * Convert.ToInt16(userAge)) - 10.8 - 5.4;

                if (BFP <= 5.0)
                {
                    res.BFResult = "Essential Fat";
                }
                else if (BFP > 5.0 && BFP <= 13.0)
                {
                    res.BFResult = "Athletes";
                }
                else if (BFP > 13.0 && BFP <= 17.0)
                {
                    res.BFResult = "Fitness";
                }
                else if (BFP > 17.0 && BFP <= 24.0)
                {
                    res.BFResult = "Average";
                }
                else if (BFP >= 25.0)
                {
                    res.BFResult = "Obese";
                }
            }

            res.FatPerc = Math.Round(BFP, 2);

            res.CalorieToBurn = 7860 * Math.Abs(kgDeficit);


            if (Convert.ToInt16(userWeight) < Convert.ToInt16(userTargetWeight))
            {
                res.Message = "You need to gain " + res.CalorieToBurn;
            }
            else if (Convert.ToInt16(userWeight) > Convert.ToInt16(userTargetWeight))
            {
                res.Message = "You need to burn " + res.CalorieToBurn;
            }
            //7860 cal for per kg




            double result=0.0;

            //Control of the workout schedules
            if (Convert.ToInt16(userTargetWeight) > Convert.ToInt16(userWeight))
            {
                res.WorkoutSchedule = workoutList;

                //also do estimations, using fixed 3k calorie for muscle growth
                if (userActivityLevel.Equals("Sedentary"))
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.Sedentary - 100);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
                else if (userActivityLevel.Equals("Moderately Active"))
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.ModeratelyActive + 70);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
                else
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.Active + 150);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
            }
            else if (Convert.ToInt16(userTargetWeight) < Convert.ToInt16(userWeight))
            {
                //remove last 3 entries which are belong to muscle growth schedule
                workoutList.RemoveLast();
                workoutList.RemoveLast();
                workoutList.RemoveLast();


                //add cardio workout schedule items
                WorkoutSchedule Jogging = new WorkoutSchedule();
                Jogging.WorkoutName = "Jogging-Treadmill";
                Jogging.SetNumber = 1;
                Jogging.RepeatNumber = "800 Meters";
                Jogging.WorkoutTargetArea = "Fat Burn & Cardio";

                workoutList.AddFirst(Jogging);

                WorkoutSchedule Rope_Jumping = new WorkoutSchedule();
                Rope_Jumping.WorkoutName = "Rope Jumping";
                Rope_Jumping.SetNumber = 6;
                Rope_Jumping.RepeatNumber = "1 Minute";
                Rope_Jumping.WorkoutTargetArea = "Fat Burn & Cardio";

                workoutList.AddFirst(Rope_Jumping);

                WorkoutSchedule Bicycling = new WorkoutSchedule();
                Bicycling.WorkoutName = "Bicycling";
                Bicycling.SetNumber = 6;
                Bicycling.RepeatNumber = "2 Minutes";
                Bicycling.WorkoutTargetArea = "Fat Burn & Cardio";

                workoutList.AddFirst(Bicycling);

                res.WorkoutSchedule = workoutList;



                //also do estimations, using fixed 3k calorie for muscle growth
                if (userActivityLevel.Equals("Sedentary"))
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.Sedentary - 100);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
                else if (userActivityLevel.Equals("Moderately Active"))
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.ModeratelyActive - 250);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
                else
                {
                    result = (res.CalorieToBurn) / (res.EstimatedCalories.Active - 400);
                    //res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7);
                }
            }
            res.EstimatedTimeToReachTarget = (int)Math.Ceiling(result / 7)+7;








            return View(res);
        }

    }
}