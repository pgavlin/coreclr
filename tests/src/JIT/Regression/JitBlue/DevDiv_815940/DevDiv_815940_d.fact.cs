using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_DevDiv_815940_DevDiv_815940_d_DevDiv_815940_d_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_815940_DevDiv_815940_d_DevDiv_815940_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_815940\\DevDiv_815940_d\\DevDiv_815940_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
