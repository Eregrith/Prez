using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Bar
    {
        public void Main()
        {
            Customer firstCustomer = new Customer();

            firstCustomer.Add(1.0, 1);

            firstCustomer.IsInHappyHour = true;
            firstCustomer.Add(1.0, 2);

            Customer secondCustomer = new Customer { IsInHappyHour = true };
            secondCustomer.Add(0.8, 1);

            firstCustomer.PrintBill();

            secondCustomer.IsInHappyHour = false;
            secondCustomer.Add(1.3, 2);
            secondCustomer.Add(2.5, 1);
            secondCustomer.PrintBill();
        }
    }


}
