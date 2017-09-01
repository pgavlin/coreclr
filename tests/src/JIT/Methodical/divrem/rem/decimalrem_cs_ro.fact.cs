using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_decimalrem_cs_ro_decimalrem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_decimalrem_cs_ro_decimalrem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\decimalrem_cs_ro\\decimalrem_cs_ro.cmd");
        }
    }
}
