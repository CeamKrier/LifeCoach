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


            //Muscle Growth Meal Plan
            LinkedList<NutritionPlan> nutritionListMuscle = new LinkedList<NutritionPlan>();

            NutritionPlan Mushroom_Egg = new NutritionPlan();
            Mushroom_Egg.NutritionName = "Mushroom & Pepper Egg White Omelet";
            Mushroom_Egg.MealType = "Breakfast";
            Mushroom_Egg.ServingAmount = "2 Omelet";
            Mushroom_Egg.CalorieOfNutrition = 643;

            nutritionListMuscle.AddLast(Mushroom_Egg);

            NutritionPlan Yogurt = new NutritionPlan();
            Yogurt.NutritionName = "Non-Fat Yogurt";
            Yogurt.MealType = "Breakfast";
            Yogurt.ServingAmount = "2 Bowl";
            Yogurt.CalorieOfNutrition = 274;

            nutritionListMuscle.AddLast(Yogurt);

            NutritionPlan Apple = new NutritionPlan();
            Apple.NutritionName = "Apple";
            Apple.MealType = "Breakfast";
            Apple.ServingAmount = "1 Apple";
            Apple.CalorieOfNutrition = 94;

            nutritionListMuscle.AddLast(Apple);

            NutritionPlan Cottage_Cheese = new NutritionPlan();
            Cottage_Cheese.NutritionName = "Cottage Cheese and Salsa";
            Cottage_Cheese.MealType = "Lunch";
            Cottage_Cheese.ServingAmount = "2 Serving";
            Cottage_Cheese.CalorieOfNutrition = 688;

            nutritionListMuscle.AddLast(Cottage_Cheese);


            NutritionPlan Granola = new NutritionPlan();
            Granola.NutritionName = "Granola";
            Granola.MealType = "Lunch";
            Granola.ServingAmount = "60 Grams";
            Granola.CalorieOfNutrition = 293;

            nutritionListMuscle.AddLast(Granola);

            NutritionPlan Salmon = new NutritionPlan();
            Salmon.NutritionName = "Balsamic Salmon";
            Salmon.MealType = "Dinner";
            Salmon.ServingAmount = "2 Serving";
            Salmon.CalorieOfNutrition = 598;

            nutritionListMuscle.AddLast(Salmon);

            NutritionPlan Artichokes = new NutritionPlan();
            Artichokes.NutritionName = "Artichokes";
            Artichokes.MealType = "Dinner";
            Artichokes.ServingAmount = "2 Serving";
            Artichokes.CalorieOfNutrition = 365;

            nutritionListMuscle.AddLast(Artichokes);







            //Cardio Meal Plan
            LinkedList<NutritionPlan> nutritionListCardio = new LinkedList<NutritionPlan>();

            NutritionPlan Steak_Egg = new NutritionPlan();
            Steak_Egg.NutritionName = "Steak and Egg Hash";
            Steak_Egg.MealType = "Breakfast";
            Steak_Egg.ServingAmount = "1 Serving";
            Steak_Egg.CalorieOfNutrition = 516;

            nutritionListCardio.AddLast(Steak_Egg);

            NutritionPlan Blueberries = new NutritionPlan();
            Blueberries.NutritionName = "Blueberries";
            Blueberries.MealType = "Breakfast";
            Blueberries.ServingAmount = "150 Grams";
            Blueberries.CalorieOfNutrition = 87;

            nutritionListCardio.AddLast(Blueberries);

            NutritionPlan Butter_Berry = new NutritionPlan();
            Butter_Berry.NutritionName = "Almond Butter Berry Protein Smoothie";
            Butter_Berry.MealType = "Lunch";
            Butter_Berry.ServingAmount = "1 Smoothie";
            Butter_Berry.CalorieOfNutrition = 448;

            nutritionListCardio.AddLast(Butter_Berry);

            NutritionPlan Butter_Celery = new NutritionPlan();
            Butter_Celery.NutritionName = "Almond Butter & Celery";
            Butter_Celery.MealType = "Lunch";
            Butter_Celery.ServingAmount = "1 Serving";
            Butter_Celery.CalorieOfNutrition = 217;

            nutritionListCardio.AddLast(Butter_Celery);

            NutritionPlan Pasta = new NutritionPlan();
            Pasta.NutritionName = "Pasta la Checca";
            Pasta.MealType = "Dinner";
            Pasta.ServingAmount = "1 Serving";
            Pasta.CalorieOfNutrition = 360;

            nutritionListCardio.AddLast(Pasta);

            NutritionPlan Cottage = new NutritionPlan();
            Cottage.NutritionName = "Cottage Cheese & Cantaloupe";
            Cottage.MealType = "Dinner";
            Cottage.ServingAmount = "1 Serving";
            Cottage.CalorieOfNutrition = 190;

            nutritionListCardio.AddLast(Cottage);




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


            double result=0.0;

            //Control of the workout schedules
            if (Convert.ToInt16(userTargetWeight) > Convert.ToInt16(userWeight))
            {
                res.NutritionPlan = nutritionListMuscle;

                res.Message = "You need to gain " + res.CalorieToBurn;

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

                res.NutritionPlan = nutritionListCardio;

                res.Message = "You need to burn " + res.CalorieToBurn;

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



                //also do estimations, using fixed 3k calories for muscle growth
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