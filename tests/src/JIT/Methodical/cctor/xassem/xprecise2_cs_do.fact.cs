using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise2_cs_do_xprecise2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise2_cs_do_xprecise2_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise2_cs_do\\xprecise2_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
