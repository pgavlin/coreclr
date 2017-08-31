using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_InnerProd_jaggedarr_cs_d_jaggedarr_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_InnerProd_jaggedarr_cs_d_jaggedarr_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\InnerProd\\jaggedarr_cs_d\\jaggedarr_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
