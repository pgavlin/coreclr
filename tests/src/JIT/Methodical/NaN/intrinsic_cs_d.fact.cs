using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_intrinsic_cs_d_intrinsic_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_d_intrinsic_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_d\\intrinsic_cs_d.cmd");
        }
    }
}
