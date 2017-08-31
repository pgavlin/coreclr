using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_76013_Dev11_76013_Dev11_76013_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_76013_Dev11_76013_Dev11_76013_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_76013\\Dev11_76013\\Dev11_76013.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
