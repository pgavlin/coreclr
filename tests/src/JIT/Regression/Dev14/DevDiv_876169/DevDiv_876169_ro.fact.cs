using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev14_DevDiv_876169_DevDiv_876169_ro_DevDiv_876169_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Dev14_DevDiv_876169_DevDiv_876169_ro_DevDiv_876169_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev14\\DevDiv_876169\\DevDiv_876169_ro\\DevDiv_876169_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
