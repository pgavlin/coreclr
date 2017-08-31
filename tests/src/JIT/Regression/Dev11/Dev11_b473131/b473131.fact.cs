using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_b473131_b473131_b473131_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_b473131_b473131_b473131_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_b473131\\b473131\\b473131.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
