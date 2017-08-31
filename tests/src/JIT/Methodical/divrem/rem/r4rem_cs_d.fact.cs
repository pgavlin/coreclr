using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_r4rem_cs_d_r4rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r4rem_cs_d_r4rem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r4rem_cs_d\\r4rem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
