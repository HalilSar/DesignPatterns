using System;

namespace DesignPatterns.Behavioral.State
{
    public class EngineOffState : State
    {
        // Parameter Engine engine
        public void Off(Engine engine)
        {
            Console.WriteLine("Engine off!");
        }
        // Parameter Engine engine
        public void On(Engine engine)
        {
            engine.AddState(new EngineOnState());
            Console.WriteLine("Engine on.");
        }
    }
}
