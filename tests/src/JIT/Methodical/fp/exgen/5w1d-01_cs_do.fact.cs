using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_5w1d_01_cs_do_5w1d_01_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_5w1d_01_cs_do_5w1d_01_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\5w1d-01_cs_do\\5w1d-01_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
