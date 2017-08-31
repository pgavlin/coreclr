using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_5w1d_03_cs_r_5w1d_03_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_5w1d_03_cs_r_5w1d_03_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\5w1d-03_cs_r\\5w1d-03_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
