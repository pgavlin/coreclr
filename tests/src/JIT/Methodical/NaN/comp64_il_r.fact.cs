using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_comp64_il_r_comp64_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp64_il_r_comp64_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp64_il_r\\comp64_il_r.cmd");
        }
    }
}
