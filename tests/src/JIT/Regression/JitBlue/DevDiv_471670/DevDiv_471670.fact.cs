using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_471670_DevDiv_471670_DevDiv_471670_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_471670_DevDiv_471670_DevDiv_471670_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_471670\\DevDiv_471670\\DevDiv_471670.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
