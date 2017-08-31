using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_815940_DevDiv_815940_r_DevDiv_815940_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_815940_DevDiv_815940_r_DevDiv_815940_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_815940\\DevDiv_815940_r\\DevDiv_815940_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
