using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_1296_GitHub_1296_GitHub_1296_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_GitHub_1296_GitHub_1296_GitHub_1296_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_1296\\GitHub_1296\\GitHub_1296.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
