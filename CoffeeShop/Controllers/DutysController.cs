using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Controllers
{
    public class DutysController : Controller
    {
        [HttpGet("/employees/{employeeId}/dutys/new")] 
        public ActionResult New(int employeeId)
        {
            Employee employee = Employee.Find(employeeId);
            return View(employee);
        }

        [HttpGet("/employees/{employeeId}/dutys/{dutyId}")]
        public ActionResult Show(int employeeId, int dutyId)
        {
            Duty duty = Duty.Find(dutyId);
            Employee employee = Employee.Find(employeeId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("duty", duty);
            model.Add("employee", employee);
            return View(model);
        }

        [HttpPost("/dutys/delete")]
        public ActionResult Destroy()
        {
            Duty.ClearAll();
            return View();
        }
    }
}
