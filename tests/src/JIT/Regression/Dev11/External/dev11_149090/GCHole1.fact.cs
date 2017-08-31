using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_149090_GCHole1_GCHole1_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_149090_GCHole1_GCHole1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_149090\\GCHole1\\GCHole1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
