using System;
using Xunit;

namespace PilotAppLib.Mathematics.Tests
{
    public class AngleTests
    {
        Angle _angle;

        [Fact]
        public void Degrees()
        {
            _angle = Angle.FromDegrees(180);

            Assert.Equal(180, _angle.Degrees);
            Assert.Equal(Math.PI, _angle.Radians);
        }

        [Fact]
        public void Radians()
        {
            _angle = Angle.FromRadians(Math.PI / 2);

            Assert.Equal(Math.PI / 2, _angle.Radians);
            Assert.Equal(90, _angle.Degrees);
        }
    }
}
