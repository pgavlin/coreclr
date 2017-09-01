using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_d_arithm32_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_d_arithm32_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_d\\arithm32_d.cmd");
        }
    }
}
