using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_u8rem_cs_d_u8rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_u8rem_cs_d_u8rem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\u8rem_cs_d\\u8rem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
