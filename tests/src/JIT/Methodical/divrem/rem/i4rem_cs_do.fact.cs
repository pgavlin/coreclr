using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_i4rem_cs_do_i4rem_cs_do_
    {
        [Fact]
        public void _divrem_rem_i4rem_cs_do_i4rem_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\i4rem_cs_do\\i4rem_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
