using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Cup : KitchenStuff
    {
        public void Produce()
        {
            Console.WriteLine("Cup produce.");
        }
    }
}
