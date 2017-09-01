using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_r8rem_cs_ro_r8rem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r8rem_cs_ro_r8rem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r8rem_cs_ro\\r8rem_cs_ro.cmd");
        }
    }
}
