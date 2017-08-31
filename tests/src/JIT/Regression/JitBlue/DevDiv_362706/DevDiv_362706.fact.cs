using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_362706_DevDiv_362706_DevDiv_362706_
    {
        [Fact]
        public void _JitBlue_DevDiv_362706_DevDiv_362706_DevDiv_362706_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_362706\\DevDiv_362706\\DevDiv_362706.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
