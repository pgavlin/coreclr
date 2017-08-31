using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_911875_DevDiv_911875_r_DevDiv_911875_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_911875_DevDiv_911875_r_DevDiv_911875_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_911875\\DevDiv_911875_r\\DevDiv_911875_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
