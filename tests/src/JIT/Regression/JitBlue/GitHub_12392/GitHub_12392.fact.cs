using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12392_GitHub_12392_GitHub_12392_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12392_GitHub_12392_GitHub_12392_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12392\\GitHub_12392\\GitHub_12392.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
