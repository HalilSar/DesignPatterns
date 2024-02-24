using System;

namespace DesignPatterns.Structural.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            KitchenStuff stuff = new CoffeeCup();
            stuff.Produce();
        }
    }
}
