using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_basics_jaggedarr_cs_d_jaggedarr_cs_d_
    {
        [Fact]
        public void _MDArray_basics_jaggedarr_cs_d_jaggedarr_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\basics\\jaggedarr_cs_d\\jaggedarr_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
