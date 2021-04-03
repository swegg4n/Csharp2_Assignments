using System;

namespace Assignment5
{
    /// <summary>
    /// EventArgs passed through event calls in the sub-pub pattern
    /// </summary>
    public class FlightUpdated_EventArgs : EventArgs
    {
        public string FlightCode { get; private set; }
        public string Status { get; private set; }
        public string Time { get; private set; }

        /// <summary>
        /// Constructor
        /// Sets the data created by the publisher
        /// </summary>
        public FlightUpdated_EventArgs(string flightCode, string status)
        {
            this.FlightCode = flightCode;
            this.Status = status;
            this.Time = DateTime.Now.ToLongTimeString();
        }
    }

}
