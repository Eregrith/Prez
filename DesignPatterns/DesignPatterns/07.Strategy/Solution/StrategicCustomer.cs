using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Solution
{
    public class StrategicCustomer
    {
        private readonly IList<double> drinks;

        public IBillingStrategy Strategy { get; set; }

        public StrategicCustomer(IBillingStrategy strategy)
        {
            this.drinks = new List<double>();
            this.Strategy = strategy;
        }

        public void Add(double price, int quantity)
        {
            drinks.Add(Strategy.GetActPrice(price * quantity));
        }

        public void PrintBill()
        {
            double sum = 0;
            foreach (double i in drinks)
            {
                sum += i;
            }
            Console.WriteLine("Total due: " + sum);
            drinks.Clear();
        }
    }
}
