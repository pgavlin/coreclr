using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_3449_GitHub_3449_GitHub_3449_
    {
        [Fact]
        public void _JitBlue_GitHub_3449_GitHub_3449_GitHub_3449_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_3449\\GitHub_3449\\GitHub_3449.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
