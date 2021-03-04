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
        public ActionResult GetList()
        {
            return View();
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
    }
}