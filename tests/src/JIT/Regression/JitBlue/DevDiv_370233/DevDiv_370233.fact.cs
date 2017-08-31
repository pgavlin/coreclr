using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_370233_DevDiv_370233_DevDiv_370233_
    {
        [Fact]
        public void _JitBlue_DevDiv_370233_DevDiv_370233_DevDiv_370233_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_370233\\DevDiv_370233\\DevDiv_370233.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
