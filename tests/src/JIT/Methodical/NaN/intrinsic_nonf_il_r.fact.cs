using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_intrinsic_nonf_il_r_intrinsic_nonf_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_nonf_il_r_intrinsic_nonf_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_nonf_il_r\\intrinsic_nonf_il_r.cmd");
        }
    }
}
