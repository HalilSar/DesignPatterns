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
            Flight landingClearanceFlight;
            if (flights.Contains(flight))
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Flight tempFlight = flights[i];
                    if (tempFlight.IsLandingClearence())
                    {
                        landingClearence = true;
                        landingClearanceFlight = tempFlight;
                        break;
                    }
                }
                if (!landingClearence)
                {
                    flight.SetLandingClearence(true);
                    Console.WriteLine("Tower: Grant Landing Clearance to " + flight.ToString());
                }
                else
                {
                    if(!flights.Contains(landingClearanceFlight))
                    {
                        Console.WriteLine("Tower: " + landingClearence.ToString() + " landing clearence. Therefore, landing clearance cannot be granted for this flight number: " + flight.ToString());
                    }
                }
            }

            else
            {
                Console.WriteLine(flight.ToString + " flight not be flights list.");
            }
        }

        public void GrantTakeoffClearance(Flight flight)
        {
            bool takeOffClearance = false;
            Flight takeOffClearanceFlight;
            if (flights.Contains(flight))
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Flight tempFlight = flights[i];
                    if (tempFlight.IsLandingClearence())
                    {
                        takeOffClearance = true;
                        takeOffClearanceFlight = tempFlight;
                        break;
                    }
                }
                if (!takeOffClearance)
                {
                    flight.SetTakeOffClearence(true);
                    Console.WriteLine("Tower: Grant Take off Clearance to " + flight.ToString());
                }
                else
                {
                    if (!flights.Contains(takeOffClearanceFlight))
                    {
                        Console.WriteLine("Tower: " + takeOffClearanceFlight.ToString() + " take off clearence. Therefore, take off clearance cannot be granted for this flight number: " + flight.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine(flight.ToString + " flight not be flights list.");
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
