using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_6649_GitHub_6649_GitHub_6649_
    {
        [Fact]
        public void _JitBlue_GitHub_6649_GitHub_6649_GitHub_6649_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_6649\\GitHub_6649\\GitHub_6649.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
