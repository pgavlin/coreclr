using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise1_cs_ro_xprecise1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise1_cs_ro_xprecise1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise1_cs_ro\\xprecise1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
