using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_911875_DevDiv_911875_d_DevDiv_911875_d_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_911875_DevDiv_911875_d_DevDiv_911875_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_911875\\DevDiv_911875_d\\DevDiv_911875_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
