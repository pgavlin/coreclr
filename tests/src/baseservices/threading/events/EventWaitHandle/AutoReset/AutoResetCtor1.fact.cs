using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_AutoReset_AutoResetCtor1_AutoResetCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_AutoReset_AutoResetCtor1_AutoResetCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\AutoReset\\AutoResetCtor1\\AutoResetCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
