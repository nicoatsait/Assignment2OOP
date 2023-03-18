using System;
using System.Collections.Generic;
using System.IO;

namespace assignment2_draft
{
    internal class ReservationManager
    {
        private List<Flight> flights = new List<Flight>();
        private string flight;

        public ReservationManager()
        {
            LoadFlights();
            FindFlight();
            CallFlight();
        }

        private void LoadFlights()
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Nico\\Downloads\\assignment2_draft\\assignment2 draft\\assignment2 draft\\Resources\\flights.csv");
            foreach (var line in lines)
            {
                string[] fields = line.Split(",");
                flights.Add(new Flight(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5], fields[6]));
            }
        }

        private string CallFlight()
        {
            foreach (Flight flight in flights) ;
            return flight;
        }

        private void FindFlight()
        {
            Console.WriteLine("Type your originating");
            string? s = Console.ReadLine();
            Console.WriteLine("Type your destination");
            string? p = Console.ReadLine();
            Console.WriteLine("Day of the week");
            string? d = Console.ReadLine();
            List<Flight> userflight = new List<Flight>();

            foreach (Flight flight in flights)
            {
                if (s == flight.GetOriginating() && p == flight.GetDestination() && d == flight.GetDay())
                {
                    Console.WriteLine($"{flight.GetFlightId()} {flight.GetAirline()} {flight.GetTime()}");
                    userflight.Add(flight);
                }
            }

            if (userflight.Count == 0)
            {
                Console.WriteLine("No flights found.");
            }
            else
            {
                Console.WriteLine("Success");
                Console.WriteLine($"{userflight.Count} flights found.");
            }
        }
    }
}

