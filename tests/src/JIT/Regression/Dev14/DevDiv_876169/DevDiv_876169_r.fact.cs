using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev14_DevDiv_876169_DevDiv_876169_r_DevDiv_876169_r_
    {
        [OuterLoop]
        [Fact]
        public void _Dev14_DevDiv_876169_DevDiv_876169_r_DevDiv_876169_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev14\\DevDiv_876169\\DevDiv_876169_r\\DevDiv_876169_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
