using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_6238_GitHub_6238_GitHub_6238_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_6238_GitHub_6238_GitHub_6238_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_6238\\GitHub_6238\\GitHub_6238.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
