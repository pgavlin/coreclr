using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_200w1d_02_cs_do_200w1d_02_cs_do_
    {
        [Fact]
        public void _fp_exgen_200w1d_02_cs_do_200w1d_02_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\200w1d-02_cs_do\\200w1d-02_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
