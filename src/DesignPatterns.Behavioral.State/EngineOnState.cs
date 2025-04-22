using System;

namespace DesignPatterns.Behavioral.State
{
    public class EngineOnState : State
    {
        // Parameter Engine engine
        public void Off(Engine engine)
        {
            engine.AddState(this);
            Console.WriteLine("Engine off.");
        }
        // Parameter Engine engine
        public void On(Engine engine)
        {
            
            Console.WriteLine("Engine on!");
        }
    }
}
