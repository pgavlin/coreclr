using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise1b_cs_r_xprecise1b_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise1b_cs_r_xprecise1b_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise1b_cs_r\\xprecise1b_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
