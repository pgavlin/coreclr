using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_Desktop_throw_cs_r_throw_cs_r_
    {
        [Fact]
        public void _cctor_misc_Desktop_throw_cs_r_throw_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\Desktop\\throw_cs_r\\throw_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
