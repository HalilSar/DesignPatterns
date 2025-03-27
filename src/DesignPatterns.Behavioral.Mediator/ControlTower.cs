using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface ControlTower
    {
        // parameter Flight flight
	void GrantTakeoffClearance(Flight flight);  
        // parameter Flight flight
	void GrantLandingClearance(Flight flight);
	// parameter Flight flight
        void AddFlight(Flight flight);
	// parameter Flight flight
        void RemoveFlight(Flight flight);
    }
}
