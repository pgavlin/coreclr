using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_cond64_il_d_cond64_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_cond64_il_d_cond64_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\cond64_il_d\\cond64_il_d.cmd");
        }
    }
}
