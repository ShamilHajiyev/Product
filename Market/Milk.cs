using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class Milk : Product
    {
        public double Volume;
        public double FatRate;
        
        public Milk(string name, double price, int count, double volume, double fatrate):base(name, price, count)
        {
            Name = name;
            Price = price;
            Count = count;
            Volume = volume;
            FatRate = fatrate;
        }
        public override void Sell(int sold)
        {
            base.Sell(sold);
            Console.WriteLine($"Volume: {Volume}l\nFat rate: {FatRate}%");
        }
    }
}
