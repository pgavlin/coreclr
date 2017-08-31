using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_Desktop_throw_cs_do_throw_cs_do_
    {
        [Fact]
        public void _cctor_misc_Desktop_throw_cs_do_throw_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\Desktop\\throw_cs_do\\throw_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
