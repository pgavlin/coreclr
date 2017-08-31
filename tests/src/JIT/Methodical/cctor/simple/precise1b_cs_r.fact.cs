using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise1b_cs_r_precise1b_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1b_cs_r_precise1b_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1b_cs_r\\precise1b_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
