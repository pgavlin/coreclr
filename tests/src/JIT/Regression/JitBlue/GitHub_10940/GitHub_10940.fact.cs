using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_10940_GitHub_10940_GitHub_10940_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_10940_GitHub_10940_GitHub_10940_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_10940\\GitHub_10940\\GitHub_10940.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
