using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_r4div_cs_ro_r4div_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_r4div_cs_ro_r4div_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\r4div_cs_ro\\r4div_cs_ro.cmd");
        }
    }
}
