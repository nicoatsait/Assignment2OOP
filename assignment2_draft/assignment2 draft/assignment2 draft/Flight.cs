using assignment2_draft.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_draft
{
    class Flight
    {
        private string flightid;
        private string originating;
        private string destination;
        private string day;
        private string time;
        private string availability;
        private string cost;
        private string airline;
        private Person person;

        public Flight(string flightid, string originating, string destination, string day, string time, string availbility, string cost)
        {
            this.flightid = flightid;
            this.originating = originating;
            this.destination = destination;
            this.day = day;
            this.time = time;
            this.availability = availbility;
            this.cost = cost;
            this.person = new Person();
            this.airline = GetAirline(flightid);
        }

        public string GetFlightId()
        {
            return flightid;
        }

        public void SetFlightId(string flightid)
        {
            this.flightid = flightid;
        }

        public string GetOriginating()
        {
            return originating;
        }

        public void SetOriginating(string originating)
        {
            this.originating = originating;
        }

        public string GetDestination()
        {
            return destination;
        }

        public void SetDestination(string destination)
        {
            this.destination = destination;
        }

        public string GetDay()
        {
            return day;
        }

        public void SetDay(string day)
        {
            this.day = day;
        }

        public string GetTime()
        {
            return time;
        }

        public void SetTime(string time)
        {
            this.time = time;
        }

        public string GetCost()
        {
            return cost;
        }

        public void SetCost(string cost)
        {
            this.cost = cost;
        }

        public string GetAvailability()
        {
            return availability;
        }

        public void SetAvailability(string availability)
        {
            this.availability = availability;
        }

        public string GetAirline()
        {
            return airline;
        }

        private string GetAirline(string flightId)
        {
            string airline = "";
            string airlineCode = flightId.Substring(0, 2);
            string[] airlines = File.ReadAllLines("C:\\Users\\Nico\\Downloads\\assignment2_draft\\assignment2 draft\\assignment2 draft\\Resources\\airlines.csv");

            foreach (string line in airlines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == airlineCode)
                {
                    airline = parts[1];
                    break;
                }
            }

            return airline;
        }

        public override string ToString()
        {
            return GetFlightId() + GetOriginating() + GetDestination() + GetDay() + GetTime() + GetAvailability() + GetCost() + GetAirline();
        }
    }
}
