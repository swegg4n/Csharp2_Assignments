using System;

namespace Assignment5
{
    public class FlightUpdated_EventArgs : EventArgs
    {
        public string FlightCode { get; private set; }
        public string Status { get; private set; }
        public string Time { get; private set; }

        public FlightUpdated_EventArgs(string flightCode, string status)
        {
            this.FlightCode = flightCode;
            this.Status = status;
            this.Time = DateTime.Now.ToLongTimeString();
        }
    }

}
