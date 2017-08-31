using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_5047_GitHub_5047_GitHub_5047_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_5047_GitHub_5047_GitHub_5047_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_5047\\GitHub_5047\\GitHub_5047.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
