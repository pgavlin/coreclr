using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_exgen_10w5d_cs_ro_10w5d_cs_ro_
    {
        [Fact]
        public void _fp_exgen_10w5d_cs_ro_10w5d_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\exgen\\10w5d_cs_ro\\10w5d_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
