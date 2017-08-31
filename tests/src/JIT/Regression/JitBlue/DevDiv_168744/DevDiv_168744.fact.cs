using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_168744_DevDiv_168744_DevDiv_168744_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_168744_DevDiv_168744_DevDiv_168744_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_168744\\DevDiv_168744\\DevDiv_168744.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
