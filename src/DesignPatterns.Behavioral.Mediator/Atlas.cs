using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Atlas : BaseFlight
    {
        public Atlas(ControlTower tower)
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
        public override string ToString()
        {
            return "Atlas flight no : 99";
        }


    }
}