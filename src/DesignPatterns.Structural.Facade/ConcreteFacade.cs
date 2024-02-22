using System;

namespace DesignPatterns.Structural.Facade
{
    public class ConcreteFacade : ComponentFacade
    {
        public void DoSomething()
        {
            new ConcreteClass().DoSomething();
        }
    }
}