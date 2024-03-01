using System;

namespace DesignPatterns.Behavioral.State
{
    public class EngineOnState : State
    {
        public void Off(Engine engine)
        {
            engine.AddState(this);
            Console.WriteLine("Engine off.");
        }

        public void On(Engine engine)
        {
            
            Console.WriteLine("Engine on");
        }
    }
}
