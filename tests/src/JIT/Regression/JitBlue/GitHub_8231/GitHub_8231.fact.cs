using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8231_GitHub_8231_GitHub_8231_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_8231_GitHub_8231_GitHub_8231_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8231\\GitHub_8231\\GitHub_8231.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
