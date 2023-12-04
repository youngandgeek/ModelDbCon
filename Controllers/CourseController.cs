using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModelDbCon.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModelDbCon.Controllers
{
    public class CourseController : Controller
    {
        //obj from db class

        DbConClass context=new DbConClass();

        public IActionResult Index()
        {
            List<Course> crsModel = context.Course.ToList();

            //pass the viewName and  the list to the  
            return View("Index", crsModel);
        }

        //to add new Course u need 2 action methods
        //-first: return empty form 
        //-second: save form data in database

        //name the html that'll return empty form Add 
        public IActionResult Add()
        {
            //to see the department options when adding new course
            //Dept is the key to use it in foreach in <select
            ViewBag.Dept = context.Department.ToList();

            //ViewBag.Departments = new SelectList(context.Department, "DepartmentId", "DepartmentName");

            return View();

        }

        //<form method="post">
        [HttpPost]
        //pass the obj from course domain model class to save the received data into the domain model class data(insted of string Name ,string ManagerName)
        public IActionResult SaveCrs(Course crs)
        {


            if (crs.Name != null)
            {
                context.Course.Add(crs);
                context.SaveChanges();
                //it'll return to index action method(show all Courses ) after saving
                return RedirectToAction("Index");

            }
            //AddDept file
            return View("Add", crs);
        }
       /** public IActionResult Edit(int id)
        {

        }
       **/
    }
}
