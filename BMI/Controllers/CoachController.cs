using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMI.Controllers
{
    public class CoachController : Controller
    {
        // GET: Coach
        public ActionResult Calculate()
        {
            return View();
        }
    }
}