using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_13561_GitHub_13561_GitHub_13561_
    {
        [Fact]
        public void _JitBlue_GitHub_13561_GitHub_13561_GitHub_13561_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_13561\\GitHub_13561\\GitHub_13561.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
