using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_intrinsic_cs_ro_intrinsic_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_ro_intrinsic_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_ro\\intrinsic_cs_ro.cmd");
        }
    }
}
