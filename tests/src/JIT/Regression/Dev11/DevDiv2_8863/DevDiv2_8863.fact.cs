using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_DevDiv2_8863_DevDiv2_8863_DevDiv2_8863_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_DevDiv2_8863_DevDiv2_8863_DevDiv2_8863_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\DevDiv2_8863\\DevDiv2_8863\\DevDiv2_8863.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
