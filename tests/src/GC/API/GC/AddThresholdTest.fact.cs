using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_AddThresholdTest_AddThresholdTest_
    {
        [Fact]
        public void _GC_AddThresholdTest_AddThresholdTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\AddThresholdTest\\AddThresholdTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
