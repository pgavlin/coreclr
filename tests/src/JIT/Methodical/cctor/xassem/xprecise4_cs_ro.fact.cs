using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_xassem_xprecise4_cs_ro_xprecise4_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_xassem_xprecise4_cs_ro_xprecise4_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\xassem\\xprecise4_cs_ro\\xprecise4_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
