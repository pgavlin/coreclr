using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_prefldinit1_il_d_prefldinit1_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_prefldinit1_il_d_prefldinit1_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\prefldinit1_il_d\\prefldinit1_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
