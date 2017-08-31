using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_174983_devdiv_174983_devdiv_174983_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_174983_devdiv_174983_devdiv_174983_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_174983\\devdiv_174983\\devdiv_174983.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
