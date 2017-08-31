using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise1b_cs_do_precise1b_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1b_cs_do_precise1b_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1b_cs_do\\precise1b_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
