using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_11814_GitHub_11814_GitHub_11814_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_11814_GitHub_11814_GitHub_11814_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_11814\\GitHub_11814\\GitHub_11814.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
