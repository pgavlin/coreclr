using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_overldrem_cs_do_overldrem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_overldrem_cs_do_overldrem_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\overldrem_cs_do\\overldrem_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
