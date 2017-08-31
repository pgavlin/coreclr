using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_462274_DevDiv_462274_DevDiv_462274_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_462274_DevDiv_462274_DevDiv_462274_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_462274\\DevDiv_462274\\DevDiv_462274.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
