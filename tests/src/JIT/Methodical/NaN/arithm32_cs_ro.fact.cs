using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_cs_ro_arithm32_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_cs_ro_arithm32_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_cs_ro\\arithm32_cs_ro.cmd");
        }
    }
}
