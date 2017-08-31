using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_AutoReset_AutoResetCast2_AutoResetCast2_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_AutoReset_AutoResetCast2_AutoResetCast2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\AutoReset\\AutoResetCast2\\AutoResetCast2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
