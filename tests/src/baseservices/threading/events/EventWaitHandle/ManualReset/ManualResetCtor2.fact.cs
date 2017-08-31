using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _events_EventWaitHandle_ManualReset_ManualResetCtor2_ManualResetCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_ManualReset_ManualResetCtor2_ManualResetCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\ManualReset\\ManualResetCtor2\\ManualResetCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
