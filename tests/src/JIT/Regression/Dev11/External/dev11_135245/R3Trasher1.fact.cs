using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_135245_R3Trasher1_R3Trasher1_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_135245_R3Trasher1_R3Trasher1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_135245\\R3Trasher1\\R3Trasher1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
