using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_AddMemoryPressureTest_AddMemoryPressureTest_
    {
        [Fact]
        public void _GC_AddMemoryPressureTest_AddMemoryPressureTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\AddMemoryPressureTest\\AddMemoryPressureTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
