using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_RemoveUsageTest_RemoveUsageTest_
    {
        [Fact]
        public void _GC_RemoveUsageTest_RemoveUsageTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\RemoveUsageTest\\RemoveUsageTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
