using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Pinned_Pinned_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Pinned_Pinned_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Pinned\\Pinned.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
