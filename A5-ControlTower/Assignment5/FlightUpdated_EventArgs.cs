using System;

namespace Assignment5
{
    public class FlightUpdated_EventArgs : EventArgs
    {
        private string flightCode;
        private string status;

        public FlightUpdated_EventArgs(string flightCode, string status)
        {
            this.flightCode = flightCode;
            this.status = status;
        }

        public string[] ToStringArray()
        {
            return new string[] { flightCode, status, DateTime.Now.ToShortTimeString() };
        }
    }

}
