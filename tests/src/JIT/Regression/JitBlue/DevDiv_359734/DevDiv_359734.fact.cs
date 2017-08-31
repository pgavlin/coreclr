using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_359734_DevDiv_359734_DevDiv_359734_
    {
        [Fact]
        public void _JitBlue_DevDiv_359734_DevDiv_359734_DevDiv_359734_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_359734\\DevDiv_359734\\DevDiv_359734.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
