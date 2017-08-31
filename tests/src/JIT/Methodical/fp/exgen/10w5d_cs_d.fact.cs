using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_10w5d_cs_d_10w5d_cs_d_
    {
        [Fact]
        public void _fp_exgen_10w5d_cs_d_10w5d_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\10w5d_cs_d\\10w5d_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
