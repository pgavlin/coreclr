using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12037_GitHub_12037_GitHub_12037_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12037_GitHub_12037_GitHub_12037_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12037\\GitHub_12037\\GitHub_12037.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
