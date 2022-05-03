using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("KitKat", 1.60, 12);
            product.Sell(5);
            Milk athena = new Milk("Athena", 1.43, 6, 1.5, 15);
            athena.Sell(4);
        }
    }
}
