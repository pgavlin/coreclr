using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_GaussJordan_classarr_cs_do_classarr_cs_do_
    {
        [Fact]
        public void _MDArray_GaussJordan_classarr_cs_do_classarr_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\GaussJordan\\classarr_cs_do\\classarr_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
