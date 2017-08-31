using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_397793_DevDiv_397793_DevDiv_397793_
    {
        [Fact]
        public void _JitBlue_DevDiv_397793_DevDiv_397793_DevDiv_397793_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_397793\\DevDiv_397793\\DevDiv_397793.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
