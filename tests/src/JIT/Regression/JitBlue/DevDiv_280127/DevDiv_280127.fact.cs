using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_280127_DevDiv_280127_DevDiv_280127_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_280127_DevDiv_280127_DevDiv_280127_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_280127\\DevDiv_280127\\DevDiv_280127.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
