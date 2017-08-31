using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_4044_GitHub_4044_GitHub_4044_
    {
        [Fact]
        public void _JitBlue_GitHub_4044_GitHub_4044_GitHub_4044_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_4044\\GitHub_4044\\GitHub_4044.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
