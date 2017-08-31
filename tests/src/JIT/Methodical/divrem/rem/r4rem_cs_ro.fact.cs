using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_r4rem_cs_ro_r4rem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r4rem_cs_ro_r4rem_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r4rem_cs_ro\\r4rem_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
