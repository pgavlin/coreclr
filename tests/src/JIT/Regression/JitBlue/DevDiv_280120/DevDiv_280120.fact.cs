using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_280120_DevDiv_280120_DevDiv_280120_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_280120_DevDiv_280120_DevDiv_280120_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_280120\\DevDiv_280120\\DevDiv_280120.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
