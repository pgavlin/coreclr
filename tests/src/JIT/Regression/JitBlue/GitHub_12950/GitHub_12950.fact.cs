using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12950_GitHub_12950_GitHub_12950_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12950_GitHub_12950_GitHub_12950_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12950\\GitHub_12950\\GitHub_12950.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
