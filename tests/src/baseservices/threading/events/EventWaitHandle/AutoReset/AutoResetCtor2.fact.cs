using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_AutoReset_AutoResetCtor2_AutoResetCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_AutoReset_AutoResetCtor2_AutoResetCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\AutoReset\\AutoResetCtor2\\AutoResetCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
