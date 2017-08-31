using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _NoGCRegion_NoGC_NoGC_
    {
        [Fact]
        public void _NoGCRegion_NoGC_NoGC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\NoGCRegion\\NoGC\\NoGC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
