using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise1b_cs_ro_precise1b_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1b_cs_ro_precise1b_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1b_cs_ro\\precise1b_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
