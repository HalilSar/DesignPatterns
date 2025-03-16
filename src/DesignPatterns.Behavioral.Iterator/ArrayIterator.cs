using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ArrayIterator : Iterator
    {
        public Beverage[] beverages;
        public int order;
        public ArrayIterator(Beverage[] beverages)
        {
            this.beverages = beverages;
        }
	// return bool
        public bool HasNext()
        {
            if (order >= beverages.Length || beverages[order] == null)
            {
                return false;
            }

            else return true;
        }
        // return object
        public object Next()
        {
            Beverage beverage = beverages[order];
            order++;
            return beverage;
        }
    }
}
