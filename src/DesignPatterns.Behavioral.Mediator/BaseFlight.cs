using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class BaseFlight : Flight
    {
        private bool completedLandingClearance;
        private bool completedTakeOffClearance;
        private bool landingClearance;  
        private bool takeoffClearance;

        public ControlTower controlTower;

        // return bool
	public bool IsLandingClearance()
        {
            return landingClearance;
        }
        // return bool
        public bool IsTakeOffClearance()
        {
            return takeoffClearance;
        }

        public abstract void RequestLandingClearance();

        public abstract void RequestTakeOffClearance();
        // parameter:  bool value
        public void SetCompleteLandingClearance(bool value)
        {
            this.completedLandingClearance = value;
            this.landingClearance = false;
            Console.WriteLine(this.ToString() + "   completed landing clearance");

        }
        // parameter : bool value
        public void SetCompleteTakeOffClearance(bool value)
        {
            this.completedTakeOffClearance = value;
            this.takeoffClearance = false;
            Console.WriteLine(this.ToString() + "   completed take off clearance");
        }
        // parameter : bool value
        public void SetLandingClearance(bool value)
        {
            this.landingClearance=value;
        }
        // parameter : bool value
        public void SetTakeOffClearance(bool value)
        {
            this.takeoffClearance = value;
        }
    }
}
