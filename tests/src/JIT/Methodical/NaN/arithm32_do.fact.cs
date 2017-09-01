using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm32_do_arithm32_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm32_do_arithm32_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm32_do\\arithm32_do.cmd");
        }
    }
}
