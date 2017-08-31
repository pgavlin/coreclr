using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_9891_GitHub_9891_GitHub_9891_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_9891_GitHub_9891_GitHub_9891_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_9891\\GitHub_9891\\GitHub_9891.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
