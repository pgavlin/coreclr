using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_dev10_94677_loopvt_loopvt_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev10_94677_loopvt_loopvt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev10_94677\\loopvt\\loopvt.cmd");
        }
    }
}
