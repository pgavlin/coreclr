using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise2_cs_ro_precise2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise2_cs_ro_precise2_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise2_cs_ro\\precise2_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
