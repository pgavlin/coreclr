using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_815940_DevDiv_815940_ro_DevDiv_815940_ro_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_815940_DevDiv_815940_ro_DevDiv_815940_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_815940\\DevDiv_815940_ro\\DevDiv_815940_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
