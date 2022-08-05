using System;
using Xunit;

namespace PilotAppLib.Mathematics.Tests
{
    public class CoordinateTests
    {
        [Fact]
        public void Constructor()
        {
            var coordinate = new Coordinate(3.0, 1.0);
            
            Assert.Equal(3.0, coordinate.Longitude);
            Assert.Equal(1.0, coordinate.Latitude);
        }

        [Fact]
        public void GetAndSet()
        {
            var coordinate = new Coordinate(0.0, 0.0);

            coordinate.Longitude = 3.0;
            coordinate.Latitude = 1.0;

            Assert.Equal(3.0, coordinate.Longitude);
            Assert.Equal(1.0, coordinate.Latitude);
        }
    }
}
