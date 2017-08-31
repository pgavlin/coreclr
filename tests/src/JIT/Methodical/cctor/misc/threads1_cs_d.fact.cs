using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_threads1_cs_d_threads1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads1_cs_d_threads1_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads1_cs_d\\threads1_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
