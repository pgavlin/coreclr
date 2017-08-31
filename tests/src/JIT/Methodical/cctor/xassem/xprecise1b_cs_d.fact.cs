using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise1b_cs_d_xprecise1b_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise1b_cs_d_xprecise1b_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise1b_cs_d\\xprecise1b_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
