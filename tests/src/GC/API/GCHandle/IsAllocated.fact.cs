using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_IsAllocated_IsAllocated_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_IsAllocated_IsAllocated_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\IsAllocated\\IsAllocated.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
