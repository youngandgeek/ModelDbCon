using Microsoft.AspNetCore.Mvc;
using ModelDbCon.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModelDbCon.Controllers
{
    public class InstructorController : Controller
    {
        //get all instructor
        public IActionResult Index()
        {
            //refrence to dbConClass 
            DbConClass context = new DbConClass();

            //return the db set values into a list

            List<Instructor> instructorModel = context.Instructor.ToList();

            //pass the viewName and  the list to the  
            return View("Instrut", instructorModel);

        }


    }
}
