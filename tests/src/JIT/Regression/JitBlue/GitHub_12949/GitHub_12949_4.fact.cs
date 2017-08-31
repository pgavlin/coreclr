using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12949_GitHub_12949_4_GitHub_12949_4_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12949_GitHub_12949_4_GitHub_12949_4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12949\\GitHub_12949_4\\GitHub_12949_4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
