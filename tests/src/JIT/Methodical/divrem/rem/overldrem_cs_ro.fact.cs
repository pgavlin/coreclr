using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_overldrem_cs_ro_overldrem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_overldrem_cs_ro_overldrem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\overldrem_cs_ro\\overldrem_cs_ro.cmd");
        }
    }
}
