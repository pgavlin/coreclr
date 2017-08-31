using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_DevDiv2_10623_DevDiv2_10623_DevDiv2_10623_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_DevDiv2_10623_DevDiv2_10623_DevDiv2_10623_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\DevDiv2_10623\\DevDiv2_10623\\DevDiv2_10623.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
