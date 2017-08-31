using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_1000w1d_cs_ro_1000w1d_cs_ro_
    {
        [Fact]
        public void _fp_exgen_1000w1d_cs_ro_1000w1d_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\1000w1d_cs_ro\\1000w1d_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
