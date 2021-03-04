using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Route("Employees")]
        public ActionResult GetList()
        {
            return View("GetList","_Layout");
        }
        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee","_Layout");
        }
    }
}