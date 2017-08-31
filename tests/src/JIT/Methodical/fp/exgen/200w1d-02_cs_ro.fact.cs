using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_200w1d_02_cs_ro_200w1d_02_cs_ro_
    {
        [Fact]
        public void _fp_exgen_200w1d_02_cs_ro_200w1d_02_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\200w1d-02_cs_ro\\200w1d-02_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
