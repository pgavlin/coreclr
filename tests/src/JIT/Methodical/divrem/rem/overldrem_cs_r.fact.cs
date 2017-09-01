using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_overldrem_cs_r_overldrem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_overldrem_cs_r_overldrem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\overldrem_cs_r\\overldrem_cs_r.cmd");
        }
    }
}
