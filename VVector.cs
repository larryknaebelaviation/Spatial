using System;
using System.Collections.Generic;
using System.Text;

namespace spatial
{
    public class VVector
    {
        private double speed;
        private double bearing;
        private double altitude;
        private DateTime datetime;

        public VVector(double speedknots, double bearingdegrees, DateTime datetime)
        {
            this.speed = speedknots;
            this.bearing = bearingdegrees;
            this.datetime = datetime;
            this.altitude = -1;
        }

        public VVector(double speedknots, double bearingdegrees, double altitude, DateTime datetime)
        {
            this.speed = speedknots;
            this.bearing = bearingdegrees;
            this.datetime = datetime;
            this.altitude = altitude;
        }

        public override string ToString()
        {
            return " SPEED_KT:" + speed + " HEADING:" + bearing + " ALT:" + altitude + " TIME:" + datetime.ToString(); 
        }
        public double getSpeed() => speed;

        public double getBearing() => bearing;

        public DateTime getTime() => datetime;

        public double getAltitude() => altitude;
    }
}
