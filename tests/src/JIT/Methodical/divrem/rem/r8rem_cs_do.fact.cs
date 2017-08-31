using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_rem_r8rem_cs_do_r8rem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r8rem_cs_do_r8rem_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r8rem_cs_do\\r8rem_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
