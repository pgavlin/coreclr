using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_180411_devdiv_180411_devdiv_180411_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_180411_devdiv_180411_devdiv_180411_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_180411\\devdiv_180411\\devdiv_180411.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
