using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_278365_DevDiv_278365_DevDiv_278365_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_278365_DevDiv_278365_DevDiv_278365_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_278365\\DevDiv_278365\\DevDiv_278365.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
