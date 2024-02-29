using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ListIterator : Iterator
    {
        public List<Beverage> beverages;
        public int order;
        public ListIterator(List<Beverage> beverages)
        {
            this.beverages = beverages;
        }
        public bool HasNext()
        {
            if (order >= beverages.Count || beverages[order] == null)
            {
                return false;
            }

            else return true;
        }

        public object Next()
        {
            Beverage beverage = beverages[order];
            order++;
            return beverage;
        }
    }
}
