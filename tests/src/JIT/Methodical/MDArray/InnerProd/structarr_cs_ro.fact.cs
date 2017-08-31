using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_structarr_cs_ro_structarr_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_structarr_cs_ro_structarr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\structarr_cs_ro\\structarr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
