using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    public class AtaturkAirportControlTower : ControlTower
    {
        private List<Flight> flights = new List<Flight>();
        public void AddFlight(Flight flight)
        {
            if (!flights.Contains(flight))
            {
                flights.Add(flight);
                Console.WriteLine("Tower: Add to  " + flight.ToString() + "at flight list ");
            }
        }

        public void GrantLandingClearance(Flight flight)
        {
            bool landingClearence = false;
            Flight landingClearanceFlight = null;
            if (flights.Contains(flight))
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Flight tempFlight = flights[i];
                    if (tempFlight.IsLandingClearance())
                    {
                        landingClearence = true;
                        landingClearanceFlight = tempFlight;
                        break;
                    }
                }
                if (!landingClearence)
                {
                    flight.SetLandingClearance(true);
                    Console.WriteLine("Tower: Grant Landing Clearance to " + flight.ToString());
                }
                else
                {
                    if(!flight.Equals(landingClearanceFlight))
                    {
                        Console.WriteLine("Tower: " + landingClearanceFlight.ToString() + " landing clearence. Therefore, landing clearance cannot be granted for this flight number: " + flight.ToString());
                    }
                }
            }

            else
            {
                Console.WriteLine(flight.ToString() + " flight not be flights list.");
            }
        }

        public void GrantTakeoffClearance(Flight flight)
        {
            bool takeOffClearance = false;
            Flight takeOffClearanceFlight = null; 
            if (flights.Contains(flight))
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Flight tempFlight = flights[i];
                    if (tempFlight.IsTakeOffClearance())
                    {
                        takeOffClearance = true;
                        takeOffClearanceFlight = tempFlight;
                        break;
                    }
                }
                if (!takeOffClearance)
                {
                    flight.SetTakeOffClearance(true);
                    Console.WriteLine("Tower: Grant Take off Clearance to " + flight.ToString());
                }
                else
                {
                    if (!flight.Equals(takeOffClearanceFlight))  
                    {
                        Console.WriteLine("Tower: " + takeOffClearanceFlight.ToString() + " take off clearence. Therefore, take off clearance cannot be granted for this flight number: " + flight.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine(flight.ToString() + " flight not be flights list.");
            }

        }

        public void RemoveFlight(Flight flight)
        {
            if (flights.Contains(flight))
            {
                flights.Remove(flight);
                Console.WriteLine("Tower: Remove to  " + flight.ToString() + "at flight list ");
            }           
        }
    }
}
