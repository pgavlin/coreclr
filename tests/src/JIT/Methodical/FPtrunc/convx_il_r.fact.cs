using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convx_il_r_convx_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convx_il_r_convx_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convx_il_r\\convx_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
