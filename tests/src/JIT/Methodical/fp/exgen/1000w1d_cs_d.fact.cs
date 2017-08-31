using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_1000w1d_cs_d_1000w1d_cs_d_
    {
        [Fact]
        public void _fp_exgen_1000w1d_cs_d_1000w1d_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\1000w1d_cs_d\\1000w1d_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
