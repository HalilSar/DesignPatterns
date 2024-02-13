using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public Bear GetBear()
        {
            return   new PolarBear();

        }

        public Tiger GetTiger()
        {
            return new BengalTiger();

          
        }
    }
}
