using System;
using System.Diagnostics;

namespace PilotAppLib.Mathematics
{
    [DebuggerDisplay("(Degrees={Degrees}, Radians={Radians})")]
    public struct Angle
    {
        private double _degrees;


        public static Angle FromDegrees(double degrees)
        {
            return new Angle {
                Degrees = degrees
            };
        }

        public static Angle FromRadians(double radians)
        {
            return new Angle {
                Radians = radians
            };
        }


        public double Degrees
        {
            get => _degrees;
            private set => _degrees = value;
        }

        public double Radians
        {
            get => (_degrees * Math.PI) / 180;
            private set => _degrees = (value / Math.PI) * 180;
        }

    }
}
