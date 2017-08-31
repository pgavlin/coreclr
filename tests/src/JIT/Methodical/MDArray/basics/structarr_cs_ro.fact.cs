using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_basics_structarr_cs_ro_structarr_cs_ro_
    {
        [Fact]
        public void _MDArray_basics_structarr_cs_ro_structarr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\basics\\structarr_cs_ro\\structarr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
