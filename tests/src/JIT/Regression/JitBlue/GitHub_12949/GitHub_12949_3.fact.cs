using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12949_GitHub_12949_3_GitHub_12949_3_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12949_GitHub_12949_3_GitHub_12949_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12949\\GitHub_12949_3\\GitHub_12949_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
