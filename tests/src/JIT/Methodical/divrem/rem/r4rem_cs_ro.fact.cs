using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_r4rem_cs_ro_r4rem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r4rem_cs_ro_r4rem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r4rem_cs_ro\\r4rem_cs_ro.cmd");
        }
    }
}
