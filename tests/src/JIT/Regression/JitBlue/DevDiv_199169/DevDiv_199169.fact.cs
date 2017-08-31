using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_199169_DevDiv_199169_DevDiv_199169_
    {
        [Fact]
        public void _JitBlue_DevDiv_199169_DevDiv_199169_DevDiv_199169_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_199169\\DevDiv_199169\\DevDiv_199169.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
