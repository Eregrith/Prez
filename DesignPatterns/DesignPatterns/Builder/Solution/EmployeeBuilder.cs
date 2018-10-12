using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Solution
{
    public class EmployeeBuilder
    {
        private Employee _currentlyBuiltEmployee;

        public EmployeeBuilder()
        {
            _currentlyBuiltEmployee = new Employee();
        }


    }
}
