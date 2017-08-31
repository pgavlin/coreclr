using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_GaussJordan_plainarr_cs_r_plainarr_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_GaussJordan_plainarr_cs_r_plainarr_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\plainarr_cs_r\\plainarr_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
