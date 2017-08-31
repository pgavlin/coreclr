using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_jaggedarr_cs_ro_jaggedarr_cs_ro_
    {
        [Fact]
        public void _MDArray_InnerProd_jaggedarr_cs_ro_jaggedarr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\jaggedarr_cs_ro\\jaggedarr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
