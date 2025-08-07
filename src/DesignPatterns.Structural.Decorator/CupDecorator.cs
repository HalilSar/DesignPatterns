using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class CupDecorator : KitchenStuff
    {
        private KitchenStuff  cup= new Cup();

        public abstract void Produce();
        
        // Return KitchenStuff
        public KitchenStuff GetCup() => cup;

        // Parameter Cup cup
        public void SetCup(Cup cup) => this.cup = cup;
    }
}
