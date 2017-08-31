using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_283795_DevDiv_283795_DevDiv_283795_
    {
        [Fact]
        public void _JitBlue_DevDiv_283795_DevDiv_283795_DevDiv_283795_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_283795\\DevDiv_283795\\DevDiv_283795.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
