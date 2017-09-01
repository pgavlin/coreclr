using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_arithm64_cs_ro_arithm64_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_cs_ro_arithm64_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_cs_ro\\arithm64_cs_ro.cmd");
        }
    }
}
