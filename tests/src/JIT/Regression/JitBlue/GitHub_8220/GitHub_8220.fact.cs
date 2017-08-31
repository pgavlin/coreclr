using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8220_GitHub_8220_GitHub_8220_
    {
        [Fact]
        public void _JitBlue_GitHub_8220_GitHub_8220_GitHub_8220_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8220\\GitHub_8220\\GitHub_8220.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
