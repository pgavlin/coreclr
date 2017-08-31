using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_13912_dev11_13912_dev11_13912_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_13912_dev11_13912_dev11_13912_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_13912\\dev11_13912\\dev11_13912.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
