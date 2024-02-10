using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class BeverageFactory
    {
       public Beverage CreateBeverage(string beverage)
       {
            if (beverage.ToLower() == "tea") return new Tea();

            else if (beverage.ToLower() == "coffee") return new Coffee();
                
            else if (beverage.ToLower() == "water") return new Water();
           
            return null; // "It's not available on the beverage menu."
       }
    }
}
