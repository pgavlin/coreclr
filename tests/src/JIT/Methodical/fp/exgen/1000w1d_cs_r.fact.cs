using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_1000w1d_cs_r_1000w1d_cs_r_
    {
        [Fact]
        public void _fp_exgen_1000w1d_cs_r_1000w1d_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\1000w1d_cs_r\\1000w1d_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
