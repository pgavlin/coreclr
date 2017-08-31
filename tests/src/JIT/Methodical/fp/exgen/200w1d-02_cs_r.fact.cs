using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_200w1d_02_cs_r_200w1d_02_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_200w1d_02_cs_r_200w1d_02_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\200w1d-02_cs_r\\200w1d-02_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
