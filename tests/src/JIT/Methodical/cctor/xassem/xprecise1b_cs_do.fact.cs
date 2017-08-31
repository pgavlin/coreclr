using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise1b_cs_do_xprecise1b_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise1b_cs_do_xprecise1b_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise1b_cs_do\\xprecise1b_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
