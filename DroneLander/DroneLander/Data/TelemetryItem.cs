using System;

namespace DroneLander
{
    public class TelemetryItem
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Tagline { get; set; }
        public double Altitude { get; set; }
        public double DescentRate { get; set; }
        public double Fuel { get; set; }
        public double Thrust { get; set; }
    }
}
