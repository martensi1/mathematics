using System;
using System.Diagnostics;

namespace PilotAppLib.Mathematics
{
    public struct Coordinate
    {
        public Coordinate(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }


        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
