using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_r_arithm32_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_r_arithm32_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_r\\arithm32_r.cmd");
        }
    }
}
