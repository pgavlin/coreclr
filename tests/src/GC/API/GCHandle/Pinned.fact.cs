using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Pinned_Pinned_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Pinned_Pinned_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Pinned\\Pinned.cmd");
        }
    }
}
