using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_prefldinit2_il_r_prefldinit2_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_prefldinit2_il_r_prefldinit2_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\prefldinit2_il_r\\prefldinit2_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
