using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_assemname_cs_r_assemname_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_assemname_cs_r_assemname_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\assemname_cs_r\\assemname_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
