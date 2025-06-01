using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        // return Bear
        public Bear GetBear()
        {
            return   new BrownBear();

        }
        //return Tiger
        public Tiger GetTiger()
        {
            return new BengalTiger();

          
        }
    }
}
