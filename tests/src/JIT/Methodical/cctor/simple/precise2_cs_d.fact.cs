using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _cctor_simple_precise2_cs_d_precise2_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise2_cs_d_precise2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise2_cs_d\\precise2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
