using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_9651_GitHub_9651_GitHub_9651_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_9651_GitHub_9651_GitHub_9651_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_9651\\GitHub_9651\\GitHub_9651.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
