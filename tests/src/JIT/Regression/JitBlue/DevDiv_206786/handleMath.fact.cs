using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_206786_handleMath_handleMath_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_206786_handleMath_handleMath_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_206786\\handleMath\\handleMath.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
