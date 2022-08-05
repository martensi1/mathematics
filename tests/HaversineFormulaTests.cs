using System;
using Xunit;

namespace PilotAppLib.Mathematics.Tests
{
    public class HaversineFormulaTests
    {
        [Theory]
        [InlineData(0.3, 0.4, 0.5, 0.6, 836.85)]
        [InlineData(-0.45, 0.9, 0.7, 0.0, 8935.31)]
        [InlineData(4.0, 4.0, 4.0, 4.0, 0.0)]
        public void CalculateDistance(
            double longitude1,
            double longitude2,
            double latitude1,
            double latitude2,
            double expectedDistance
            )
        {
            var coordinate1 = new Coordinate(longitude1, latitude1);
            var coordinate2 = new Coordinate(longitude2, latitude2);

            double distance = HaversineFormula.CalculateDistance(coordinate1, coordinate2);
            Assert.Equal(expectedDistance, distance, 2);
        }
    }
}
