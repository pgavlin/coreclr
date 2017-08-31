using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_r8rem_cs_r_r8rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r8rem_cs_r_r8rem_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r8rem_cs_r\\r8rem_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
