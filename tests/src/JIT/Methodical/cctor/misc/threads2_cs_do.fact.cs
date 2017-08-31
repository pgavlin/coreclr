using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_threads2_cs_do_threads2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_do_threads2_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_do\\threads2_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
