using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_DevDiv2_11321_DevDiv2_11321_DevDiv2_11321_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_DevDiv2_11321_DevDiv2_11321_DevDiv2_11321_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\DevDiv2_11321\\DevDiv2_11321\\DevDiv2_11321.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
