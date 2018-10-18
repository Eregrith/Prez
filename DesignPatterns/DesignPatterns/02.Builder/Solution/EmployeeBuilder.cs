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

        public EmployeeBuilder CreateEmployee()
        {
            _currentlyBuiltEmployee = new Employee
            {
                DaysWorked = new List<DayWorked>()
            };

            return this;
        }

        public EmployeeBuilder WithSalaryInEuros(int v)
        {
            _currentlyBuiltEmployee.Salary = new Salary
            {
                Amount = 500000,
                Currency = new MoneyCurrency
                {
                    Label = "EUR",
                    ChangeCoeffToDollar = 1.4
                }
            };
            return this;
        }

        public Employee GetEmployee()
        {
            return _currentlyBuiltEmployee;
        }

        public EmployeeBuilder WithDaysWorkedRange(DateTime start, DateTime end)
        {
            if (start > end)
            {
                DateTime save = start;
                start = end;
                end = save;
            }
            while (start != end)
            {
                _currentlyBuiltEmployee.DaysWorked.Add(new DayWorked { Date = start });
                start.AddDays(1);
            }
            return this;
        }

        public EmployeeBuilder WithAValidContract()
        {
            _currentlyBuiltEmployee.Contract = new Contract
            {
                Start = DateTime.Today.AddDays(-6),
                End = null
            };
            return this;
        }
    }
}
