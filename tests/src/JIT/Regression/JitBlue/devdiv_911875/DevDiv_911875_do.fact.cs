using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_911875_DevDiv_911875_do_DevDiv_911875_do_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_911875_DevDiv_911875_do_DevDiv_911875_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_911875\\DevDiv_911875_do\\DevDiv_911875_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
