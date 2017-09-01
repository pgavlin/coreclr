using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_cs_do_arithm32_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_cs_do_arithm32_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_cs_do\\arithm32_cs_do.cmd");
        }
    }
}
