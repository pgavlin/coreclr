using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_prefldinit2_il_d_prefldinit2_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_prefldinit2_il_d_prefldinit2_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\prefldinit2_il_d\\prefldinit2_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
