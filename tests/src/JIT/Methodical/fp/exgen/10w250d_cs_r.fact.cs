using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_10w250d_cs_r_10w250d_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_10w250d_cs_r_10w250d_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\10w250d_cs_r\\10w250d_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
