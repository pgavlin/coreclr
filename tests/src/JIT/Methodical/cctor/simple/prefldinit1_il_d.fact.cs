using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_prefldinit1_il_d_prefldinit1_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_prefldinit1_il_d_prefldinit1_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\prefldinit1_il_d\\prefldinit1_il_d.cmd");
        }
    }
}
