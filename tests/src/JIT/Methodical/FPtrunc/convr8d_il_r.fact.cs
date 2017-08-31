using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convr8d_il_r_convr8d_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8d_il_r_convr8d_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8d_il_r\\convr8d_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
