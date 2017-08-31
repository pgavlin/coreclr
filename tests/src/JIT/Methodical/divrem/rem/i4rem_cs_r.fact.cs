using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_i4rem_cs_r_i4rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_i4rem_cs_r_i4rem_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i4rem_cs_r\\i4rem_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
