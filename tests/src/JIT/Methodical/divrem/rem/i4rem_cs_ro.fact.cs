using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_i4rem_cs_ro_i4rem_cs_ro_
    {
        [Fact]
        public void _divrem_rem_i4rem_cs_ro_i4rem_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i4rem_cs_ro\\i4rem_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
