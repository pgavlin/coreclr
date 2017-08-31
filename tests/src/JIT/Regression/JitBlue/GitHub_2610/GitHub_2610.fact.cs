using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_2610_GitHub_2610_GitHub_2610_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_2610_GitHub_2610_GitHub_2610_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_2610\\GitHub_2610\\GitHub_2610.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
