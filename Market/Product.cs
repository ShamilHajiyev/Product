using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome;

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public virtual void Sell(int sold)
        {
            if(sold < Count && Count != 0)
            {
                Count -= sold;
                TotalIncome += sold * Price;
                Console.WriteLine($"Name: {Name}\nProduct left: {Count}\nTotal income: {TotalIncome}$");
            }
        }
    }
}
