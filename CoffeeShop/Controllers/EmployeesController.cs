using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet("/employees")] //display all employees
        public ActionResult Index()
        {
            List<Employee> allEmployees = Employee.GetAll();
            return View(allEmployees);
        }

        [HttpGet("/employees/new")] // user creates new employee with form
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/employees")] //process form submission
        public ActionResult Create(string employeeName) //accepts argument because it is referring to the contents in the form
        {
            Employee newEmployee = new Employee(employeeName); //creates a new employee
            return RedirectToAction("Index"); //send the user back to the index route
        }

        [HttpGet("/employees/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Employee selectedEmployee = Employee.Find(id);
            List<Duty> employeeDutys = selectedEmployee.Dutys;
            model.Add("employee", selectedEmployee); //keys in dictionary employee and Dutys 
            model.Add("dutys", employeeDutys);
            return View(model);
        }

        // creates new Dutys for an employee
        [HttpPost("/employees/{employeeId}/dutys")]
        public ActionResult Create(int employeeId, string dutyDescription)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Employee foundEmployee = Employee.Find(employeeId);
            Duty newDuty = new Duty(dutyDescription);
            newDuty.Save();
            foundEmployee.AddDuty(newDuty);
            List<Duty> employeeDutys = foundEmployee.Dutys;
            model.Add("dutys", employeeDutys);
            model.Add("employee", foundEmployee);
            return View("Show", model);
        }
    }
}