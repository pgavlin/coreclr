using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_13486_GitHub_13486_GitHub_13486_
    {
        [Fact]
        public void _JitBlue_GitHub_13486_GitHub_13486_GitHub_13486_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_13486\\GitHub_13486\\GitHub_13486.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
