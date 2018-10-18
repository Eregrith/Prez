using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Solution
{
    public class EmployeeTests
    {
        public void Employee_WithHighSalary_Should_Be_Happy()
        {
            int highSalary = 500000;
            EmployeeBuilder builder = new EmployeeBuilder();
            builder.CreateEmployee()
                   .WithAValidContract()
                   .WithDaysWorkedRange(DateTime.Today.AddDays(-3), DateTime.Today.AddDays(-1))
                   .WithSalaryInEuros(highSalary);
            Employee employeeTested = builder.GetEmployee();

            Assert.IsTrue(employeeTested.GetHappinessPercent() > 75);
        }

        public void Employee_WithLowSalary_Should_Be_Sad()
        {
            int lowSalary = 50;
            EmployeeBuilder builder = new EmployeeBuilder();
            builder.CreateEmployee()
                   .WithAValidContract()
                   .WithDaysWorkedRange(DateTime.Today.AddDays(-3), DateTime.Today.AddDays(-1))
                   .WithSalaryInEuros(lowSalary);
            Employee employeeTested = builder.GetEmployee();

            Assert.IsTrue(employeeTested.GetHappinessPercent() < 25);
        }

        public void Employee_WithAverageSalary_Should_Be_Of_Average_Happiness()
        {
            int averageSalary = 5000;
            EmployeeBuilder builder = new EmployeeBuilder();
            builder.CreateEmployee()
                   .WithAValidContract()
                   .WithSalaryInEuros(averageSalary);
            Employee employeeTested = builder.GetEmployee();

            int happiness = employeeTested.GetHappinessPercent();
            Assert.IsTrue(happiness > 25 && happiness < 75);
        }
    }
}
