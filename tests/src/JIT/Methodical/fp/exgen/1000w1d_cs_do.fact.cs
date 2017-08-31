using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_1000w1d_cs_do_1000w1d_cs_do_
    {
        [Fact]
        public void _fp_exgen_1000w1d_cs_do_1000w1d_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\1000w1d_cs_do\\1000w1d_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
