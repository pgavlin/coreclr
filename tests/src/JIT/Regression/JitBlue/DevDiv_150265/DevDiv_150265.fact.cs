using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_150265_DevDiv_150265_DevDiv_150265_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_150265_DevDiv_150265_DevDiv_150265_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_150265\\DevDiv_150265\\DevDiv_150265.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
