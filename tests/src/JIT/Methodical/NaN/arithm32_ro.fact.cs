using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_ro_arithm32_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_ro_arithm32_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_ro\\arithm32_ro.cmd");
        }
    }
}
