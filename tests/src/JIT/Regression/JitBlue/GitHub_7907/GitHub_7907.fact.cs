using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_7907_GitHub_7907_GitHub_7907_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_7907_GitHub_7907_GitHub_7907_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_7907\\GitHub_7907\\GitHub_7907.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
