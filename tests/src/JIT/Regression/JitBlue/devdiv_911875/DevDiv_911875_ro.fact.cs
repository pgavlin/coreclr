using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_devdiv_911875_DevDiv_911875_ro_DevDiv_911875_ro_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_devdiv_911875_DevDiv_911875_ro_DevDiv_911875_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\devdiv_911875\\DevDiv_911875_ro\\DevDiv_911875_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
