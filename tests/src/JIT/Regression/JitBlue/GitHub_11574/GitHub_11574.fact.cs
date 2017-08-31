using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11574_GitHub_11574_GitHub_11574_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_11574_GitHub_11574_GitHub_11574_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11574\\GitHub_11574\\GitHub_11574.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
