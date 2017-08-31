using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_816617_DevDiv_816617_do_DevDiv_816617_do_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_816617_DevDiv_816617_do_DevDiv_816617_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_816617\\DevDiv_816617_do\\DevDiv_816617_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
