using Microsoft.AspNetCore.Mvc;
using ModelDbCon.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModelDbCon.Controllers
{
    public class DeptController : Controller
    {
        //index-> getAll Departments method 
        public IActionResult Index()
        {
            //refrence to dbConClass 
            DbConClass context = new DbConClass();
            
            //return the db set values into a list

        List<Department> deptsModel = context.Department.ToList();
            
            //pass the viewName and  the list to the  
            return View("dept",deptsModel);
        }
    }
}
