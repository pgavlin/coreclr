using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_10w250d_cs_d_10w250d_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_10w250d_cs_d_10w250d_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\10w250d_cs_d\\10w250d_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
