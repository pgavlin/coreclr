using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_cs_do_arithm64_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_cs_do_arithm64_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_cs_do\\arithm64_cs_do.cmd");
        }
    }
}
