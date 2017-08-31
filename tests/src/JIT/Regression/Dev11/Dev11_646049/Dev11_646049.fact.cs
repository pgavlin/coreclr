using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_646049_Dev11_646049_Dev11_646049_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_646049_Dev11_646049_Dev11_646049_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_646049\\Dev11_646049\\Dev11_646049.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
