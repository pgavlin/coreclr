using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278372_DevDiv_278372_DevDiv_278372_
    {
        [Fact]
        public void _JitBlue_DevDiv_278372_DevDiv_278372_DevDiv_278372_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278372\\DevDiv_278372\\DevDiv_278372.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
