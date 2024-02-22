using System;

namespace DesignPatterns.Structural.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var factory = FacadeFactory.GetInstance();
            factory.GetFacade().DoSomething();
        }
    }
}
