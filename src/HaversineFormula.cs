using System;

namespace PilotAppLib.Mathematics
{
    public static class HaversineFormula
    {
        public static double CalculateDistance(Coordinate coordinate1, Coordinate coordinate2)
        {
            return GetSphereDistance(
                coordinate1.Longitude,
                coordinate2.Longitude,
                coordinate1.Latitude,
                coordinate2.Latitude,
                Constants.EarthRadiusKilometers
                );
        }


        private static double GetSphereDistance(
            double longitude1,
            double longitude2,
            double latitude1,
            double latitude2,
            double sphereRadius
            )
        {
            // Using the law of haversines, the distance between two points
            // on a sphere can be determined
            //
            // θ: central angle (angle between the two points)
            // d: distance between two points along a great circle of a sphere
            // r: sphere radius
            //
            // θ = d / r
            //
            // Haversine formula:
            //  hav(θ) = hav(lat2 - lat1) + cos(lat1) * cos(lat2) * hav(long2 - long1)
            // Alternate formula (without cosines):
            //  hav(θ) = hav(lat2 - lat1) + (1 - hav(lat1 - lat2) - hav(lat1 + lat2)) * hav(long2 - long1)
            double deltaLongitude = longitude2 - longitude1;
            double deltaLatitude = latitude2 - latitude1;
            double sumLatitude = latitude1 + latitude2;

            double centralAngleHaversine = GetHaversine(deltaLatitude) +
                   (1 - GetHaversine(-1 * deltaLatitude) - GetHaversine(sumLatitude)) * GetHaversine(deltaLongitude);

            double centralAngle = GetInverseHaversine(centralAngleHaversine);
            double distance = centralAngle * sphereRadius;

            return distance;
        }

        private static double GetHaversine(double angle)
        {
            return Math.Pow(Math.Sin(angle / 2), 2);
        }

        private static double GetInverseHaversine(double haversine)
        {
            return Math.Asin(Math.Sqrt(haversine)) * 2;
        }
    }
}
