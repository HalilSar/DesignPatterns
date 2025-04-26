using System;

namespace DesignPatterns.Behavioral.State
{
    public interface State
    {
       // Paramater Engine engine
        void On(Engine engine);
        // Paramater Engine engine
        void Off(Engine engine);
    }
}
