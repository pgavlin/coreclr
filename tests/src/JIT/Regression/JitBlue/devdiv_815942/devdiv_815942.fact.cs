using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_815942_devdiv_815942_devdiv_815942_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_815942_devdiv_815942_devdiv_815942_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_815942\\devdiv_815942\\devdiv_815942.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
