using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Solution
{
    public interface IService
    {
        string GetEmployeeName(Guid id);

        int GetAverageAgeOfEmployeesWithNameContaining(string partOfName);

        void CreateEmployee(string name, int age);
    }
}
