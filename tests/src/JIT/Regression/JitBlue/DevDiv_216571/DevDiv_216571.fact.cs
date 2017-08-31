using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_216571_DevDiv_216571_DevDiv_216571_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_216571_DevDiv_216571_DevDiv_216571_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_216571\\DevDiv_216571\\DevDiv_216571.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
