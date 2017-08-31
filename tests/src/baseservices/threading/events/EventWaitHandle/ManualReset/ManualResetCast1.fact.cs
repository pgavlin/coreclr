using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_ManualReset_ManualResetCast1_ManualResetCast1_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_ManualReset_ManualResetCast1_ManualResetCast1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\ManualReset\\ManualResetCast1\\ManualResetCast1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
