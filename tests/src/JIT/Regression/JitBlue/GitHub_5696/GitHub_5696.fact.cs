using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_5696_GitHub_5696_GitHub_5696_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_5696_GitHub_5696_GitHub_5696_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_5696\\GitHub_5696\\GitHub_5696.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
