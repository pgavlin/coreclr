using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_200492_DevDiv_200492_DevDiv_200492_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_200492_DevDiv_200492_DevDiv_200492_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_200492\\DevDiv_200492\\DevDiv_200492.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
