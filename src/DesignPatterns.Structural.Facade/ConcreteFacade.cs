using System;

namespace DesignPatterns.Structural.Facade
{
    public class ConcreteFacade : ComponentFacade
    {
        public void DoSomething()
        {
           Console.WriteLine("ConcreteFacade :DoSomething run");
        }
    }
}