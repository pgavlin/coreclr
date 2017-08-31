using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev14_DevDiv_876169_DevDiv_876169_d_DevDiv_876169_d_
    {
        [OuterLoop]
        [Fact]
        public void _Dev14_DevDiv_876169_DevDiv_876169_d_DevDiv_876169_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev14\\DevDiv_876169\\DevDiv_876169_d\\DevDiv_876169_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
