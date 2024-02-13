using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();
            var bear = factory.GetBear();
            var tiger = factory.GetTiger();
            Console.WriteLine("Bear:" + " " + bear.GetBearSpecies());
            Console.WriteLine("Tiger:" + " " + tiger.GetTigerSpecies());
            Console.WriteLine("**************************");
            factory = new ConcreteFactory2();
            bear = factory.GetBear();
            tiger = factory.GetTiger();
            Console.WriteLine("Bear:" + " " + bear.GetBearSpecies());
            Console.WriteLine("Tiger:" + " " + tiger.GetTigerSpecies());
        }
    }
}
