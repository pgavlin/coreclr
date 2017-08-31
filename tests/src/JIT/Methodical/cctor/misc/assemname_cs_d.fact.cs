using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_misc_assemname_cs_d_assemname_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_assemname_cs_d_assemname_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\assemname_cs_d\\assemname_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
