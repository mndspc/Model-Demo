using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDemo.Models;
namespace ModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
       
        // GET: Employee
        public ActionResult Index()
        {
            EmpMaster empMaster = new EmpMaster {EmpCode=100,EmpName="Scott",Email="scott@gmail.com" };
            return View(empMaster);
        }

        public ActionResult ShowEmployees()
        {
            List<EmpMaster> empList = new List<EmpMaster>
            {
            new EmpMaster{EmpCode=100,EmpName="Scott",Email="scott@gmail.com" },
            new EmpMaster{EmpCode=101,EmpName="Tiger",Email="tiger@gmail.com" },
            new EmpMaster{EmpCode=102,EmpName="Smith",Email="smith@gmail.com"}
            };

            return View(empList);
        }
    }
}