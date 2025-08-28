using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ColdDrink : Menu
    {
        public Beverage[] beverages { get; }
        public ColdDrink()
        {
           beverages=   new Beverage[4];
           beverages[0] = new Beverage { Name = "Water" };
           beverages[1] = new Beverage { Name = "Soda" };
           beverages[2] = new Beverage { Name = "Iced tea" };
           beverages[3] = new Beverage { Name = "Lemonade" };
           beverages[3] = new Beverage { Name = "Iced Coffee" };
        }

        // return Iterator
        public Iterator GetIterator()
        {
            return   new ArrayIterator(beverages);
        }
    }
}
