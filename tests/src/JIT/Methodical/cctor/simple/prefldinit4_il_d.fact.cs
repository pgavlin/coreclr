using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_prefldinit4_il_d_prefldinit4_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_prefldinit4_il_d_prefldinit4_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\prefldinit4_il_d\\prefldinit4_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
