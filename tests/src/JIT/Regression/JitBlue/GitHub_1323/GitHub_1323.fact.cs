using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_1323_GitHub_1323_GitHub_1323_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_1323_GitHub_1323_GitHub_1323_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_1323\\GitHub_1323\\GitHub_1323.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
