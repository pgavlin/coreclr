using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _flowgraph_dev10_bug642944_GCMaskForGSCookie_GCMaskForGSCookie_
    {
        [OuterLoop]
        [Fact]
        public void _flowgraph_dev10_bug642944_GCMaskForGSCookie_GCMaskForGSCookie_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\flowgraph\\dev10_bug642944\\GCMaskForGSCookie\\GCMaskForGSCookie.cmd");
        }
    }
}
