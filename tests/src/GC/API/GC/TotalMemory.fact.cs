using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_TotalMemory_TotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _GC_TotalMemory_TotalMemory_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\TotalMemory\\TotalMemory.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
