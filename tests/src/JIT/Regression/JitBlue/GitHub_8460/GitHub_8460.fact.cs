using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8460_GitHub_8460_GitHub_8460_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_8460_GitHub_8460_GitHub_8460_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8460\\GitHub_8460\\GitHub_8460.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
