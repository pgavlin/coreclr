using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_815941_devdiv_815941_devdiv_815941_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_815941_devdiv_815941_devdiv_815941_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_815941\\devdiv_815941\\devdiv_815941.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
