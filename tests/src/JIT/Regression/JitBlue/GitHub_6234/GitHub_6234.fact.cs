using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_6234_GitHub_6234_GitHub_6234_
    {
        [Fact]
        public void _JitBlue_GitHub_6234_GitHub_6234_GitHub_6234_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_6234\\GitHub_6234\\GitHub_6234.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
