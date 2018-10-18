using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Report
    {
        public void ExportSalary()
        {
            Employee employee = new Employee();

            Export(employee.CalculatePay());
        }

        public void ExportSalaryWithoutOvertime()
        {
            Employee employee = new Employee();

            Export(employee.CalculatePayWithoutOvertime());
        }

        public void ExportSalaryWithoutHolidays()
        {
            Employee employee = new Employee();

            Export(employee.CalculatePayWithoutHolidays());
        }

        public void ExportSalaryPerMonth()
        {
            Employee employee = new Employee();

            Export(employee.CalculatePayPerMonth());
        }

        private void Export(ExportData data)
        {
            // on s'en fout, en vrai
        }
    }
}
