using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise1b_cs_d_precise1b_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1b_cs_d_precise1b_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1b_cs_d\\precise1b_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
