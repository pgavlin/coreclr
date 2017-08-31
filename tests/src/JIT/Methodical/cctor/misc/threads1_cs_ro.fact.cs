using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_threads1_cs_ro_threads1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads1_cs_ro_threads1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads1_cs_ro\\threads1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
