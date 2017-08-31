using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_5437_Dev11_5437_Dev11_5437_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_5437_Dev11_5437_Dev11_5437_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_5437\\Dev11_5437\\Dev11_5437.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
