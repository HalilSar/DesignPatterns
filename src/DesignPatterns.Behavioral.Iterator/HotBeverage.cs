using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class HotBeverage : Menu
    {
        public List<Beverage> beverages { get; }
        public HotBeverage()
        {
            beverages = new List<Beverage>();
            beverages.Add(new Beverage { Name = "Coffee" });
            beverages.Add(new Beverage { Name = "Tea" });
            beverages.Add(new Beverage { Name = "Hot chocolate" });
            beverages.Add(new Beverage { Name = "Herbal tea" });
            beverages.Add(new Beverage { Name = "Hot milk" });
            beverages.Add(new Beverage { Name = "Matcha latte" });
            beverages.Add(new Beverage { Name = "Spiced cai" });
        }
        public Iterator GetIterator()
        {
            return  new ListIterator(beverages);
        }
    }
}
