using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_TotalMemory2_TotalMemory2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_TotalMemory2_TotalMemory2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\TotalMemory2\\TotalMemory2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
