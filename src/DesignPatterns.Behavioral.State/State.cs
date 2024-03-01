using System;

namespace DesignPatterns.Behavioral.State
{
    public interface State
    {
        void On(Engine engine);
        void Of(Engine engine);
    }
}
