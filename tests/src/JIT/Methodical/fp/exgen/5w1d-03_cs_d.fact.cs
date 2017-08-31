using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_5w1d_03_cs_d_5w1d_03_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_5w1d_03_cs_d_5w1d_03_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\5w1d-03_cs_d\\5w1d-03_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
