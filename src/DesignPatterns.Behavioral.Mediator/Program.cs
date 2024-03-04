using System;

namespace DesignPatterns.Behavioral.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower tower = new AtaturkAirportControlTower();

            Flight thy1991 = new Thy1991(tower);
            Flight atlas = new Atlas(tower);

            thy1991.RequestLandingClearance();
            atlas.RequestLandingClearance();
            thy1991.SetCompleteLandingClearance(true);
            thy1991.RequestLandingClearance();
            atlas.RequestLandingClearance();
            atlas.SetCompleteLandingClearance(true);


            thy1991.RequestTakeOffClearance();
            atlas.RequestTakeOffClearance();
            thy1991.SetCompleteTakeOffClearance(true);
            atlas.RequestTakeOffClearance();
            thy1991.RequestTakeOffClearance();
            atlas.SetCompleteTakeOffClearance(true);

            
           




        }
    }
}
