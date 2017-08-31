using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_throw_cs_ro_throw_cs_ro_
    {
        [Fact]
        public void _cctor_misc_throw_cs_ro_throw_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\throw_cs_ro\\throw_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
