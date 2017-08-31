using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_12761_GitHub_12761_GitHub_12761_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_12761_GitHub_12761_GitHub_12761_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_12761\\GitHub_12761\\GitHub_12761.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
