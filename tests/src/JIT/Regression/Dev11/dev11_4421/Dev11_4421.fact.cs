using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_4421_Dev11_4421_Dev11_4421_
    {
        [Fact]
        public void _Dev11_dev11_4421_Dev11_4421_Dev11_4421_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_4421\\Dev11_4421\\Dev11_4421.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
