using System;

namespace DesignPatterns.Behavioral.State
{
    public class Engine
    {
        private  State state;
       
        public Engine()
        {
            AddState(new EngineOffState());
            Console.WriteLine("Engine close.");
        }

        public void Stop() => this.state.Off(this);
        public void Start() => this.state.On(this);

        public void AddState(State state) => this.state = state;
    }
}
