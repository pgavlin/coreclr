using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_comp32_il_r_comp32_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp32_il_r_comp32_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp32_il_r\\comp32_il_r.cmd");
        }
    }
}
