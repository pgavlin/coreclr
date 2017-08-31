using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11689_GitHub_11689_GitHub_11689_
    {
        [Fact]
        public void _JitBlue_GitHub_11689_GitHub_11689_GitHub_11689_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11689\\GitHub_11689\\GitHub_11689.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
