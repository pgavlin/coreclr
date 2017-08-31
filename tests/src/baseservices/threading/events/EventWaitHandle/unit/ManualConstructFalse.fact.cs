using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_unit_ManualConstructFalse_ManualConstructFalse_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_ManualConstructFalse_ManualConstructFalse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\ManualConstructFalse\\ManualConstructFalse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
