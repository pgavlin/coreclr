using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_367099_DevDiv_367099_DevDiv_367099_
    {
        [Fact]
        public void _JitBlue_DevDiv_367099_DevDiv_367099_DevDiv_367099_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_367099\\DevDiv_367099\\DevDiv_367099.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
