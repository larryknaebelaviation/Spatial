using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace spatial
{
    public class Position
    {
        private double latitude = 0d;
        private double longitude = 0d;
        private double altitude = 0d;

        public Position(double latitude, double longitude, double altitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.altitude = altitude;
        }


        public double getLatitude() => latitude;

        public double getLongitude() => longitude;

        public double getAltitude() => altitude;

        public void setAltitude(double alt) => altitude = alt;

        public void setLatitude(double lat) => latitude = lat;

        public void setLongitude(double lon) => longitude = lon;

        override public string ToString()
        {
            return $" lat={latitude} lon={longitude} alt={altitude} ";
        }
    }
}
