using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_cs_r_arithm64_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_cs_r_arithm64_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_cs_r\\arithm64_cs_r.cmd");
        }
    }
}
