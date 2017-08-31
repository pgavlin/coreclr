using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_200w1d_01_cs_d_200w1d_01_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_200w1d_01_cs_d_200w1d_01_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\200w1d-01_cs_d\\200w1d-01_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
