using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_threads2_cs_r_threads2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_r_threads2_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_r\\threads2_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
