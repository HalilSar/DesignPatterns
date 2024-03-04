using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface ControlTower
    {
        void GrantTakeoffClearance(Flight flight);  
        void GrantLandingClearance(Flight flight); 
        void AddFlight(Flight flight);  
    }
}
