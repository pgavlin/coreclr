using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_279829_DevDiv_279829_DevDiv_279829_
    {
        [Fact]
        public void _JitBlue_DevDiv_279829_DevDiv_279829_DevDiv_279829_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_279829\\DevDiv_279829\\DevDiv_279829.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
