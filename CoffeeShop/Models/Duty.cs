using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public class Duty
    {
        public string DutyDescription { get; set; }
        public int Id { get; }
        private static List<Duty> _instances = new List<Duty> { };

        public Duty(string dutyDescription)
        {
            DutyDescription = dutyDescription;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static Duty Find(int searchId)
        {
            return _instances[searchId-1];
        }

        public static List<Duty> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}