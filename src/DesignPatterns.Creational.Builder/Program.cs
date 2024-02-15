using System;

namespace DesignPatterns.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager manager = new OrderManager();
            manager.CreateOrder("Ford", "Focus", "White", 170);
            manager.ShowOrder();
            Console.WriteLine("******************************");
            manager = new OrderManager();
            manager.CreateOrder("Audi", "A5", "Dark", 270);
            manager.ShowOrder();
            Console.WriteLine("******************************");

        }
    }
}
