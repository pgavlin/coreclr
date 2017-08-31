using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_RemoveMemoryPressureTest_RemoveMemoryPressureTest_
    {
        [Fact]
        public void _GC_RemoveMemoryPressureTest_RemoveMemoryPressureTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\RemoveMemoryPressureTest\\RemoveMemoryPressureTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
