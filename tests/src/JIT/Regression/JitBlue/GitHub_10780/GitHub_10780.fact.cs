using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10780_GitHub_10780_GitHub_10780_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10780_GitHub_10780_GitHub_10780_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10780\\GitHub_10780\\GitHub_10780.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
