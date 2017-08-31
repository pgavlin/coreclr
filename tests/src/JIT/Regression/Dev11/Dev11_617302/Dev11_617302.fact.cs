using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_617302_Dev11_617302_Dev11_617302_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_617302_Dev11_617302_Dev11_617302_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_617302\\Dev11_617302\\Dev11_617302.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
