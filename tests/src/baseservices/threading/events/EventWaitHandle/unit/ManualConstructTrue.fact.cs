using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_unit_ManualConstructTrue_ManualConstructTrue_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_unit_ManualConstructTrue_ManualConstructTrue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\unit\\ManualConstructTrue\\ManualConstructTrue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
