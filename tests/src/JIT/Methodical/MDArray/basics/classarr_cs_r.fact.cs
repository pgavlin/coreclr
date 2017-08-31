using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_basics_classarr_cs_r_classarr_cs_r_
    {
        [Fact]
        public void _MDArray_basics_classarr_cs_r_classarr_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\basics\\classarr_cs_r\\classarr_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
