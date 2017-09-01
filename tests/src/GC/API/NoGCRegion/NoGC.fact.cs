using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _NoGCRegion_NoGC_NoGC_
    {
        [Fact]
        public void _NoGCRegion_NoGC_NoGC_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\NoGCRegion\\NoGC\\NoGC.cmd");
        }
    }
}
