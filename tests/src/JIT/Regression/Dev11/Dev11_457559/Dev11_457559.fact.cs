using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_457559_Dev11_457559_Dev11_457559_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_457559_Dev11_457559_Dev11_457559_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_457559\\Dev11_457559\\Dev11_457559.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
