using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Water:Beverage
    {
       // return string
       public string GetBeverageType()
       {
            return "Water";
       }
    }
}
