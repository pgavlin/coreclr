using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_overldrem_cs_r_overldrem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_overldrem_cs_r_overldrem_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\overldrem_cs_r\\overldrem_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
