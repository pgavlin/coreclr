using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_r8rem_cs_ro_r8rem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r8rem_cs_ro_r8rem_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r8rem_cs_ro\\r8rem_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
