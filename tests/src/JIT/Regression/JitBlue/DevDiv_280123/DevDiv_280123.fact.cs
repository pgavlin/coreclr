using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_280123_DevDiv_280123_DevDiv_280123_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_280123_DevDiv_280123_DevDiv_280123_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_280123\\DevDiv_280123\\DevDiv_280123.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
