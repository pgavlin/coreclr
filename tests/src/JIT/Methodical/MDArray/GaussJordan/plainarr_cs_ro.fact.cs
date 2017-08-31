using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_GaussJordan_plainarr_cs_ro_plainarr_cs_ro_
    {
        [Fact]
        public void _MDArray_GaussJordan_plainarr_cs_ro_plainarr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\plainarr_cs_ro\\plainarr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
