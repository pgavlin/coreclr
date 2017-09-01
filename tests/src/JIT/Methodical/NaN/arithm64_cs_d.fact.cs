using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_cs_d_arithm64_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_cs_d_arithm64_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_cs_d\\arithm64_cs_d.cmd");
        }
    }
}
