using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_cs_r_arithm32_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_cs_r_arithm32_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_cs_r\\arithm32_cs_r.cmd");
        }
    }
}
