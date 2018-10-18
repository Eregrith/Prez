using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Builder
{
    public class Employee
    {
        public List<DayWorked> DaysWorked { get; internal set; }
        public Salary Salary { get; internal set; }
        public Contract Contract { get; internal set; }

        internal int GetHappinessPercent()
        {
            double convertedSalary = Salary.Amount * Salary.Currency.ChangeCoeffToDollar;
            return convertedSalary > 50000 ?
                        90
                        : convertedSalary > 500 ?
                          40
                          : 10;
        }
    }
}