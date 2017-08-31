using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_2580_GitHub_2580_GitHub_2580_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_2580_GitHub_2580_GitHub_2580_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_2580\\GitHub_2580\\GitHub_2580.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
