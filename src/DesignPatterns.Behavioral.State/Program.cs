using System;

namespace DesignPatterns.Behavioral.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Stop();
            engine.Start();
            
        }
    }
}
