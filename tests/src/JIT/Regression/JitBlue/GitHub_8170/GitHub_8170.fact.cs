using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8170_GitHub_8170_GitHub_8170_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_8170_GitHub_8170_GitHub_8170_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8170\\GitHub_8170\\GitHub_8170.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
