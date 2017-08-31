using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_10w250d_cs_do_10w250d_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _fp_exgen_10w250d_cs_do_10w250d_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\10w250d_cs_do\\10w250d_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
