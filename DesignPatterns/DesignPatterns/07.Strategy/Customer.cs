using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    internal class Customer
    {
        private readonly IList<double> _drinks;

        public Customer()
        {
            _drinks = new List<double>();
        }

        public bool IsInHappyHour { get; set; }

        public void Add(double price, int quantity)
        {
            price = price * quantity;

            if (IsInHappyHour)
                price *= 0.5;

            _drinks.Add(price);
        }

        public void PrintBill()
        {
            double sum = 0;
            foreach (double i in _drinks)
            {
                sum += i;
            }
            Console.WriteLine("Total due: " + sum);
            _drinks.Clear();
        }
    }
}