using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class BaseFlight : Flight
    {
        public bool completedLandingClearance;
        public bool completedTakeOffClearance;
        public bool landingClearance;  // completedTakeOffClearance
        public bool takeoffClearance;

        public Flight flight;
        public abstract bool IsLandingClearance();
   

        public abstract bool IsTakeOffClearance();


        public void RequestLandingClearance()
        {
            throw new System.NotImplementedException();
        }

        public void RequestTakeOffClearance()
        {
            throw new System.NotImplementedException();
        }

        public void SetCompleteLandingClearance(bool value)
        {
            this.completedLandingClearance = value;
            this.landingClearance = false;
            Console.WriteLine(this.ToString() + "   completed landing clearance");

        }

        public void SetCompleteTakeOffClearance(bool value)
        {
            this.completedTakeOffClearance = value;
            this.takeoffClearance = false;
            Console.WriteLine(this.ToString() + "   completed take off clearance");
        }

        public void SetLandingClearance(bool value)
        {
            this.landingClearance=value;
        }

        public void SetTakeOffClearance(bool value)
        {
            this.takeoffClearance = value;
        }
    }
}