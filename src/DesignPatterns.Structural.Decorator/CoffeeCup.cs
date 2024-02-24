using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class CoffeeCup : CupDecorator
    {
        public override void Produce()
        {
            GetCup().Produce();
            AddGrip();
        }

        public void AddGrip() => Console.WriteLine("Handle add to cup");
    }
}
