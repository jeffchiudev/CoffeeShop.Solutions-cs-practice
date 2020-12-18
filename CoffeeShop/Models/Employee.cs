using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public class Employee
    {
        private static List<Employee> _instances = new List<Employee> {};
        public string EmployeeName { get; set; }
        public int Id { get; }
        public List<Duty> Dutys { get; set; }
        
        public Employee(string employeeName)
        {
            EmployeeName = employeeName;
            _instances.Add(this);
            Id = _instances.Count;
            Dutys = new List<Duty>{ };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Employee> GetAll()
        {
            return _instances;
        }

        public static Employee Find(int searchId)
        {
            return _instances[searchId-1];
        }

        public void AddDuty(Duty duty)
        {
            Dutys.Add(duty);
        }
    }
}


