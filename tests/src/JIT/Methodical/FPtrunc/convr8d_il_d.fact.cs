using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _FPtrunc_convr8d_il_d_convr8d_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8d_il_d_convr8d_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8d_il_d\\convr8d_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
