using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_dev11_10427_conv_ovf_i4_conv_ovf_i4_
    {
        [Fact]
        public void _Dev11_dev11_10427_conv_ovf_i4_conv_ovf_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_10427\\conv_ovf_i4\\conv_ovf_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
