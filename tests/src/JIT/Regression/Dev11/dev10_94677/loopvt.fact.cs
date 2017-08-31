using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev10_94677_loopvt_loopvt_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev10_94677_loopvt_loopvt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev10_94677\\loopvt\\loopvt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
