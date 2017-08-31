using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_u4rem_cs_d_u4rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_u4rem_cs_d_u4rem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\u4rem_cs_d\\u4rem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
