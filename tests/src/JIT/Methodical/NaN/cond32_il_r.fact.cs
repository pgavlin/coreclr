using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_cond32_il_r_cond32_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond32_il_r_cond32_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond32_il_r\\cond32_il_r.cmd");
        }
    }
}
