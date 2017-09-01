using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_cond32_il_d_cond32_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond32_il_d_cond32_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond32_il_d\\cond32_il_d.cmd");
        }
    }
}
