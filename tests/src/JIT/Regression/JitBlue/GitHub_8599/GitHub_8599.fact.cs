using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_8599_GitHub_8599_GitHub_8599_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_8599_GitHub_8599_GitHub_8599_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_8599\\GitHub_8599\\GitHub_8599.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
