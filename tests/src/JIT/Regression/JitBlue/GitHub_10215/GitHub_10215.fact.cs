using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10215_GitHub_10215_GitHub_10215_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10215_GitHub_10215_GitHub_10215_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10215\\GitHub_10215\\GitHub_10215.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
