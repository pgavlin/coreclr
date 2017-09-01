using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_cond64_il_r_cond64_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond64_il_r_cond64_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond64_il_r\\cond64_il_r.cmd");
        }
    }
}
