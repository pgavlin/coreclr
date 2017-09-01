using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_intrinsic_cs_r_intrinsic_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_r_intrinsic_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_r\\intrinsic_cs_r.cmd");
        }
    }
}
