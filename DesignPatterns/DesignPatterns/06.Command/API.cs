using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Six
{
    public class Api
    {
        private readonly Service _service;

        public Api()
        {
            _service = new Service();
        }

        public string GetEmployeeName(Guid id)
            => _service.GetEmployeeName(id);

        public int GetAverageAgeOfEmployeesWithNameContaining(string partOfName)
            => _service.GetAverageAgeOfEmployeesWithNameContaining(partOfName);

        public void CreateEmployee(string name, int age)
            => _service.CreateEmployee(name, age);
    }
}