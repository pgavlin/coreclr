using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_405852_DevDiv_405852_DevDiv_405852_
    {
        [Fact]
        public void _JitBlue_DevDiv_405852_DevDiv_405852_DevDiv_405852_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_405852\\DevDiv_405852\\DevDiv_405852.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
