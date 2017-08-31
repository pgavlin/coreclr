using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_assemname_cs_do_assemname_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_assemname_cs_do_assemname_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\assemname_cs_do\\assemname_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
