using System;

namespace DesignPatterns.Behavioral.State
{
    public class EngineOffState : State
    {
        public void Off(Engine engine)
        {
            Console.WriteLine("Engine off.");
        }

        public void On(Engine engine)
        {
            engine.On(new EngineOnState());
            Console.WriteLine("Engine on");
        }
    }
}
