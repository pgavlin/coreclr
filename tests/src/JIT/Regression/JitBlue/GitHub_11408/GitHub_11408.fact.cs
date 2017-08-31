using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11408_GitHub_11408_GitHub_11408_
    {
        [ActiveIssue("11408")]
        [Fact]
        public void _JitBlue_GitHub_11408_GitHub_11408_GitHub_11408_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11408\\GitHub_11408\\GitHub_11408.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
