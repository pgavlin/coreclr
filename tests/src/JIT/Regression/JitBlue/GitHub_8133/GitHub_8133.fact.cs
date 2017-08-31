using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8133_GitHub_8133_GitHub_8133_
    {
        [Fact]
        public void _JitBlue_GitHub_8133_GitHub_8133_GitHub_8133_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8133\\GitHub_8133\\GitHub_8133.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
