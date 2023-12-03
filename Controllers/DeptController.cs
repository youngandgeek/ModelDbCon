using Microsoft.AspNetCore.Mvc;
using ModelDbCon.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModelDbCon.Controllers
{
    public class DeptController : Controller
    {
<<<<<<< HEAD
<<<<<<< HEAD
        DbConClass context = new DbConClass();

=======
>>>>>>> 44fc04c9f338df2b74800cb9597a2b7068ade73c
=======
>>>>>>> e3789e6ace9ab11a19b7d47e80b46bae6b3e7efc
        //index-> getAll Departments method 
        public IActionResult Index()
        {
            //refrence to dbConClass 
<<<<<<< HEAD
<<<<<<< HEAD
=======
            DbConClass context = new DbConClass();
>>>>>>> 44fc04c9f338df2b74800cb9597a2b7068ade73c
=======
            DbConClass context = new DbConClass();
>>>>>>> e3789e6ace9ab11a19b7d47e80b46bae6b3e7efc
            
            //return the db set values into a list

        List<Department> deptsModel = context.Department.ToList();
            
            //pass the viewName and  the list to the  
            return View("dept",deptsModel);
        }
<<<<<<< HEAD
<<<<<<< HEAD

        //return specific department detail, pass the id and check with FirstOrDefault the first match to this Id-> return it
        public IActionResult Detail(int id) {
            Department depar= context.Department.FirstOrDefault(d=>d.Id==id);

            //pass the view file name and the value we stored the id in
            return View("Detail",depar);
        }

        //to add new department u need 2 action methods
        //-first: return empty form 
        //-second: save form data in database

        public IActionResult AddDept()
        {
            return View();
        }

        //<form method="post">
        [HttpPost]
        public IActionResult SaveDept(Department dept)
        {

           
                if (dept.Name != null)
                {
                    context.Department.Add(dept);
                    context.SaveChanges();
                //it'll return to index action method(show all departments) after saving
                    return RedirectToAction("Index");

                }
                //AddDept file
                return View("AddDept", dept);
                //return RedirectToAction("DEatils", new{ id=dept.Id});
            }
        }
=======
    }
>>>>>>> 44fc04c9f338df2b74800cb9597a2b7068ade73c
=======
    }
>>>>>>> e3789e6ace9ab11a19b7d47e80b46bae6b3e7efc
}
