using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_255263_DevDiv_255263_DevDiv_255263_
    {
        [Fact]
        public void _JitBlue_DevDiv_255263_DevDiv_255263_DevDiv_255263_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_255263\\DevDiv_255263\\DevDiv_255263.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
