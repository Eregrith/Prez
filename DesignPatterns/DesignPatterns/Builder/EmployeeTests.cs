using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EmployeeTests
    {
        public void Employee_WithHighSalary_Should_Be_Happy()
        {
            Employee employeeTested = new Employee
            {
                Contract = new Contract
                {
                    Start = DateTime.Today.AddDays(-6),
                    End = null
                },
                Salary = new Salary
                {
                    Amount = 500000,
                    Currency = new MoneyCurrency
                    {
                        Label = "EUR",
                        ChangeCoeffToDollar = 1.4
                    }
                },
                DaysWorked = new List<DayWorked>
                {
                    new DayWorked { Date = DateTime.Today.AddDays(-3) },
                    new DayWorked { Date = DateTime.Today.AddDays(-2) },
                    new DayWorked { Date = DateTime.Today.AddDays(-1) }
                }
            };

            Assert.IsTrue(employeeTested.GetHappinessPercent() > 75);
        }

        public void Employee_WithLowSalary_Should_Be_Sad()
        {
            Employee employeeTested = new Employee
            {
                Contract = new Contract
                {
                    Start = DateTime.Today.AddDays(-6),
                    End = null
                },
                Salary = new Salary
                {
                    Amount = 50,
                    Currency = new MoneyCurrency
                    {
                        Label = "EUR",
                        ChangeCoeffToDollar = 1.4
                    }
                },
                DaysWorked = new List<DayWorked>
                {
                    new DayWorked { Date = DateTime.Today.AddDays(-3) },
                    new DayWorked { Date = DateTime.Today.AddDays(-2) },
                    new DayWorked { Date = DateTime.Today.AddDays(-1) }
                }
            };

            Assert.IsTrue(employeeTested.GetHappinessPercent() < 25);
        }

        public void Employee_WithAverageSalary_Should_Be_Of_Average_Happiness()
        {
            Employee employeeTested = new Employee
            {
                Contract = new Contract
                {
                    Start = DateTime.Today.AddDays(-6),
                    End = null
                },
                Salary = new Salary
                {
                    Amount = 5000,
                    Currency = new MoneyCurrency
                    {
                        Label = "EUR",
                        ChangeCoeffToDollar = 1.4
                    }
                },
                DaysWorked = new List<DayWorked>()
            };

            int happiness = employeeTested.GetHappinessPercent();
            Assert.IsTrue(happiness > 25 && happiness < 75);
        }
    }
}
