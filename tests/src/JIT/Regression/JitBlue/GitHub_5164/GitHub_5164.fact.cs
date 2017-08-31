using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_5164_GitHub_5164_GitHub_5164_
    {
        [Fact]
        public void _JitBlue_GitHub_5164_GitHub_5164_GitHub_5164_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_5164\\GitHub_5164\\GitHub_5164.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
