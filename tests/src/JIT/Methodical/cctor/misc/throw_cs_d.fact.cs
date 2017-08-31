using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_throw_cs_d_throw_cs_d_
    {
        [Fact]
        public void _cctor_misc_throw_cs_d_throw_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\throw_cs_d\\throw_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
