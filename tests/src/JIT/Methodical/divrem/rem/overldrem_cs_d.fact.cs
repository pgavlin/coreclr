using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_overldrem_cs_d_overldrem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_overldrem_cs_d_overldrem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\overldrem_cs_d\\overldrem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
