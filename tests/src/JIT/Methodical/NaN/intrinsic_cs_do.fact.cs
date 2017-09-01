using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_intrinsic_cs_do_intrinsic_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_intrinsic_cs_do_intrinsic_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\intrinsic_cs_do\\intrinsic_cs_do.cmd");
        }
    }
}
