using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_cs_d_arithm32_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_cs_d_arithm32_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_cs_d\\arithm32_cs_d.cmd");
        }
    }
}
