using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_comp32_il_d_comp32_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_comp32_il_d_comp32_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\comp32_il_d\\comp32_il_d.cmd");
        }
    }
}
