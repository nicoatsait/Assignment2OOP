using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_draft
{
    internal class Reservation
    {
        private string reservationid;
        private bool status;
        private Flight flight;
        private Person person;



        public Reservation(string reservationid, string flightid, string airline, string originating, string destination, string day, string time, string cost, string name, string citizenship, bool status)
        {
            this.reservationid = reservationid;
            this.status = status;
        }

        public string GetReservationId()
        {
            return reservationid;
        }

        public void SetReservationId(string reservationid)
        {
            this.reservationid = reservationid;
        }

        public bool GetStatus()
        {
            return status;
        }

        public void SetStatus(bool status)
        {
            this.status = status;
        }

    }
}
