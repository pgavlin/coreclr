using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _v4_dev10_804810_dev10_804810_dev10_804810_
    {
        [OuterLoop]
        [Fact]
        public void _v4_dev10_804810_dev10_804810_dev10_804810_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\v4\\dev10_804810\\dev10_804810\\dev10_804810.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
