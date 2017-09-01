using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _events_EventWaitHandle_ManualReset_ManualResetCast1_ManualResetCast1_
    {
        [OuterLoop]
        [Fact]
        public void _events_EventWaitHandle_ManualReset_ManualResetCast1_ManualResetCast1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\events\\EventWaitHandle\\ManualReset\\ManualResetCast1\\ManualResetCast1.cmd");
        }
    }
}
