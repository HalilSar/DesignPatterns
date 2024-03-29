﻿using System;
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

        public KitchenStuff GetCup() => cup;
        public void SetCup(Cup cup) => this.cup = cup;
    }
}
