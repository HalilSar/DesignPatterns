using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverageFactory = new BeverageFactory();
            Beverage beverage = beverageFactory.CreateBeverage("TEA");
            Console.WriteLine("Beverage:" + " " + beverage.GetBeverageType());
            Beverage beverage2 = beverageFactory.CreateBeverage("WATER");
            Console.WriteLine("Beverage:" + " " + beverage2.GetBeverageType());
            Beverage beverage3 = beverageFactory.CreateBeverage("COFFEE");
            Console.WriteLine("Beverage:" + " " + beverage3.GetBeverageType());
        }
    }
}
