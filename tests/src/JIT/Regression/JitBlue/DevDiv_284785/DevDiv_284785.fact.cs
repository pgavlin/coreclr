using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_284785_DevDiv_284785_DevDiv_284785_
    {
        [Fact]
        public void _JitBlue_DevDiv_284785_DevDiv_284785_DevDiv_284785_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_284785\\DevDiv_284785\\DevDiv_284785.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
