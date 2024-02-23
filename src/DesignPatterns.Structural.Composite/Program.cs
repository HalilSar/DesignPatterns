using System;

namespace DesignPatterns.Structural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();

            Part mouse = new Mouse();
            comp.AddPart(mouse);

            Part keyboard = new Keyboard();
            comp.AddPart(keyboard);

            Part monitor = new Monitor();
            comp.AddPart(monitor);

            Part ram = new RAM();
            comp.AddPart(ram);

            Console.WriteLine("Total : " + comp.GetPrice().ToString());
        }
    }
}
