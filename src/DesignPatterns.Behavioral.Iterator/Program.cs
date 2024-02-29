using System;

namespace DesignPatterns.Behavioral.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            HotBeverage hotBeverage = new HotBeverage();
            Iterator it = new ListIterator(hotBeverage.beverages);
            while (it.HasNext())
            {
                Beverage beverage = (Beverage)it.Next();
                Console.WriteLine(beverage.Name);
            }

            ColdDrink coldDrink = new ColdDrink();
            it = new ArrayIterator(coldDrink.beverages);
            while (it.HasNext())
            {
                Beverage beverage = (Beverage)it.Next();
                Console.WriteLine(beverage.Name);
            }
        }
    }
}
