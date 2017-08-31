using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11804_GitHub_11804_GitHub_11804_
    {
        [Fact]
        public void _JitBlue_GitHub_11804_GitHub_11804_GitHub_11804_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11804\\GitHub_11804\\GitHub_11804.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
