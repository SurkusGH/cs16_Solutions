using cs16_paskaita_Solutions;
using System;
using Xunit;

namespace xUnit_ForRoundThings
{
    public class UnitTest1
    {
        [Fact]
        public void Test_to_assert_caculation_correctness()
        {
            // Arange
            var circle = new Circle(5d);
            var cylinder = new Cylinder(10d, 5d);
            // Act
            double test1result = circle.GetAreaData();
            double test2result = cylinder.GetVolumeData();
            // Asert
            Assert.Equal(79, Math.Round(test1result));
            Assert.Equal(785, Math.Round(test2result));
        }
    }
}
