using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_comp64_il_d_comp64_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp64_il_d_comp64_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp64_il_d\\comp64_il_d.cmd");
        }
    }
}
