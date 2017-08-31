using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_461649_DevDiv_461649_DevDiv_461649_
    {
        [Fact]
        public void _JitBlue_DevDiv_461649_DevDiv_461649_DevDiv_461649_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_461649\\DevDiv_461649\\DevDiv_461649.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
