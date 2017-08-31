using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_3w1d_01_cs_d_3w1d_01_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_3w1d_01_cs_d_3w1d_01_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\3w1d-01_cs_d\\3w1d-01_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
