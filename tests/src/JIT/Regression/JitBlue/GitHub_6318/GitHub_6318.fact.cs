using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_6318_GitHub_6318_GitHub_6318_
    {
        [Fact]
        public void _JitBlue_GitHub_6318_GitHub_6318_GitHub_6318_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_6318\\GitHub_6318\\GitHub_6318.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
