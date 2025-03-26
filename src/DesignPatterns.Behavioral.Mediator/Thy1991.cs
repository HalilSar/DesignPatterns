using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Thy1991 : BaseFlight
    {
        public Thy1991(ControlTower tower)
        {
            this.controlTower = tower;
            tower.AddFlight(this);
        }
        public override void RequestLandingClearance()
        {
           controlTower.GrantLandingClearance(this);
        }

        public override void RequestTakeOffClearance()
        {
            controlTower.GrantTakeoffClearance(this);
        }
        // return string
	public override string ToString()
        {
            return "Thy flight no :1991";
        }


    }
}
