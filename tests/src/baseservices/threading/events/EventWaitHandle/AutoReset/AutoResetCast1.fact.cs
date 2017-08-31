using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_AutoReset_AutoResetCast1_AutoResetCast1_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_AutoReset_AutoResetCast1_AutoResetCast1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\AutoReset\\AutoResetCast1\\AutoResetCast1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
