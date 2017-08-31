using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_GetTotalMemory_GetTotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetTotalMemory_GetTotalMemory_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\GetTotalMemory\\GetTotalMemory.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
