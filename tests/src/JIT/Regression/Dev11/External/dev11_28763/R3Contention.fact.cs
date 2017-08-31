using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_28763_R3Contention_R3Contention_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_28763_R3Contention_R3Contention_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_28763\\R3Contention\\R3Contention.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
