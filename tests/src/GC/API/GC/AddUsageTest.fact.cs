using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_AddUsageTest_AddUsageTest_
    {
        [Fact]
        public void _GC_AddUsageTest_AddUsageTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\AddUsageTest\\AddUsageTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
